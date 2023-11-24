using System;
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

    public partial class DepartmentSearching : UserControl
    {
        private DBManager dbManager;
        private string query;

        public DepartmentSearching()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();
        }

        private void DepartmentSearching_Load(object sender, EventArgs e)
        {
            UpdateDepartmentComboBox();
        }
        private void searching_depart_all_result_btn_Click(object sender, EventArgs e)
        {
            dbManager.InitDBManager();

            try
            {
                // DataGridView를 초기화
                depature_result_show_GV.DataSource = null;
                depature_result_show_GV.Rows.Clear();

                // 부서 테이블에서 부서이름과 부서장이름을 조회
                string query = Query.GetInstance()
                            .select("부서이름, 부서장이름")
                            .from("부서")
                            .exec();

                DataTable dataTable = dbManager.FindDataTable(query);

                // 결과를 DataGridView에 바인딩
                depature_result_show_GV.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
        private void UpdateDepartmentComboBox()
        {
            dbManager.InitDBManager();

            try
            {
                // 부서 이름들을 조회
                string query = Query.GetInstance()
                            .select("부서이름")
                            .from("부서")
                            .exec();

                List<string> departmentNames = dbManager.GetList(query, "부서이름");

                after_input_or_update_depart_name_showing_comboxBox_for_searching.Items.Clear();
                foreach (var name in departmentNames)
                {
                    after_input_or_update_depart_name_showing_comboxBox_for_searching.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
        private void specific_depart_name_searching_Click(object sender, EventArgs e)
        {

            string selectedDepartmentName = after_input_or_update_depart_name_showing_comboxBox_for_searching.SelectedItem.ToString();

            dbManager.InitDBManager();

            try
            {
                // DataGridView를 초기화
                depature_result_show_GV.DataSource = null;
                depature_result_show_GV.Rows.Clear();

                // 선택된 부서의 부서장 정보를 데이터베이스에서 조회
                string query = Query.GetInstance()
                            .select("부서이름, 부서장이름")
                            .from("부서")
                            .where($"부서이름 = '{selectedDepartmentName}'")
                            .exec();

                DataTable dataTable = dbManager.FindDataTable(query);

                // 조회한 결과를 DataGridView에 바인딩
                depature_result_show_GV.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
        // 

        private void recent_exist_department_employee_name_searching_btn_Click(object sender, EventArgs e)
        {
            // 콤보박스에서 선택된 부서이름을 가져옵니다.
            string selectedDepartmentName = after_input_or_update_depart_name_showing_comboxBox_for_searching.SelectedItem.ToString();

            dbManager.InitDBManager();

            try
            {
                // 사원 테이블에서 부서이름, 사원ID, 이름을 조회하고 부서이름으로 정렬
                string query = "SELECT 부서이름, 사원ID, 이름 FROM 사원 WHERE 부서이름 = '" + selectedDepartmentName + "' ORDER BY 부서이름, 사원ID, 이름";

                DataTable dataTable = dbManager.FindDataTable(query);

                // 조회한 결과를 DataGridView에 바인딩
                depature_result_show_GV.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
    }
}
