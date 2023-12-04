using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DBP_TeamProject.Forms.SalaryManagement
{
    public partial class SalaryList : UserControl
    {
        private string userId = null;
        private string whereString;
        public SalaryList()
        {
            InitializeComponent();
            InitializeDateTimePicker();


        }

        public void InitializeDateTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM";
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            string regularWorkHours; // 정규 근로 시간
            string overtimeHours; // 추가 근로 시간

            DateTime date = dateTimePicker1.Value;
            string selectedDate = date.ToString("yyyy-MM");

            if (LoginedUser.getInstance().Level == "관리자") // 관리자라면 모든 사원 급여 출력
            {
                whereString = $"근로일자 = '{selectedDate}'";
            }
            else // 관리자가 아니라면 본인 급여 출력
            {
                userId = LoginedUser.getInstance().UserId;
                whereString = $"근로일자 = '{selectedDate}' AND 사원ID = '{userId}'";
            }

            try
            {
                string query = Query.GetInstance()
                                .select("사원ID, 근로일자 AS 연월, 총근로시간, (연장근로시간+야간근로시간+휴일근로시간) AS 추가근로시간, " +
                                "ROUND((총근로시간*(SELECT 시급 FROM 시급)) + " + // 기본급
                                "((연장근로시간+야간근로시간+휴일근로시간)*(SELECT 시급 FROM 시급)*0.5)) AS 총급여," + // + 수당 = [총급여]
                                "ROUND((연장근로시간+야간근로시간+휴일근로시간)*(SELECT 시급 FROM 시급)*1.5) AS 추가수당," + // [추가수당]
                                "ROUND((SELECT 국민연금+국민건강보험+국민건강보험_장기요양+고용보험료 FROM 공제),4) AS 총보험률," + // [보험률], 소숫점 3자리까지
                                "ROUND(((총근로시간*(SELECT 시급 FROM 시급)) + ((연장근로시간+야간근로시간+휴일근로시간)*(SELECT 시급 FROM 시급)*0.5)) * " + // 총급여 *
                                "((100 - (SELECT 국민연금+국민건강보험+국민건강보험_장기요양+고용보험료 FROM 공제))/100)) AS 실수령액")  // * (100-공제)/100 = [실수령액]
                                .from("근로시간")
                                .where(whereString)
                                .orderBy("사원ID ASC")
                                .exec();

                DataTable dataTable = DBManager.GetInstance().InitDBManager().FindDataTable(query);
                salaryScreen.DataSource = dataTable;
                salaryScreen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                salaryScreen.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
        }
    }
}
