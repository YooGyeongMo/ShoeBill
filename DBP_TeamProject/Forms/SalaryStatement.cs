using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject.Forms
{
    public partial class SalaryStatement : UserControl
    {
        public SalaryStatement()
        {
            InitializeComponent();
        }

        private void salaryLoadButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetBasicSalary();
            salaryDataGridView.DataSource = dataTable;
            salaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DBManager.GetInstance().CloseConnection();
        }
        // [#1] 기본급 출력
        public DataTable GetBasicSalary()
        {
            string query = Query.GetInstance().
                select("사원ID, SUM(TIMESTAMPDIFF(HOUR, 출근시간, 퇴근시간)) * (SELECT 시급 FROM 시급) AS 월기본급").
                from("출근부").
                where("퇴근여부='Y'").
                groupBy("사원ID, MONTH(출근시간), MONTH(퇴근시간)").
                exec();
            return DBManager.GetInstance().InitDBManager().FindDataTable(query);
        }
    }
}
