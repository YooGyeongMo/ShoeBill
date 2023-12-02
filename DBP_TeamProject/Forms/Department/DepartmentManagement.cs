using MySql.Data.MySqlClient;
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
    public partial class DepartmentManagement : UserControl
    {
        private DBManager dbManager;
        private string query;

        public DepartmentManagement()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();

            if (LoginedUser.getInstance().Level != "관리자")
            {
                departmentPanel.Enabled = false;
            }
        }


        private void depatment_name_insert_btn_Click(object sender, EventArgs e)
        {
            if (department_name_input_textbox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }
            string departmentName = department_name_input_textbox.Text;

            dbManager.InitDBManager();

            try
            {
                //중복 검사 쿼리
                string checkDuplicationQuery = Query.GetInstance()
                             .select("COUNT(*)")
                             .from("부서")
                             .where($"부서이름 = '{departmentName}'")
                             .exec();
                if (dbManager.IsDuplicated(checkDuplicationQuery))
                {
                    MessageBox.Show("동일한 부서 이름이 이미 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 새 부서 추가 쿼리
                string insertQuery = Query.GetInstance()
                    .insert("부서 (부서이름)")
                    .values($"('{departmentName}')")
                    .exec();
                dbManager.ExecuteNonQueury(insertQuery);
                MessageBox.Show("부서가 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateUI();
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

        private void UpdateUI()
        {
            UpdateDepartmentComboBox();

            delete_depatment_name_input_textbox.Text = "";
            department_name_input_textbox.Text = "";
            for_update_department_name_input_textbox.Text = "";
            recent_department_list_combobox.SelectedIndex = -1;
            recent_department_name_list_for_leader_searching_combobox.SelectedIndex = -1;
            for_depatment_leader_input_employeeName_textBox.Text = "";
        }

        //부서명을 콤보박스에서 현재 존재하는 것을 선택한 후 수정쿼리 보내기 위한 버튼
        private void depatment_name_update_btn_Click(object sender, EventArgs e)
        {
            if (for_update_department_name_input_textbox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }
            if (recent_department_list_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("부서를 선택해주세요.");
                return;
            }
            string newDepartmentName = for_update_department_name_input_textbox.Text;
            string currentDepartmentName = recent_department_list_combobox.SelectedItem.ToString();

            dbManager.InitDBManager();

            try
            {
                // 새로운 부서 이름이 이미 존재하는지 확인
                string checkNewDepartmentNameExistsQuery = Query.GetInstance()
                            .select("COUNT(*)")
                            .from("부서")
                            .where($"부서이름 = '{newDepartmentName}'")
                            .exec();

                MySqlCommand cmd = new MySqlCommand(checkNewDepartmentNameExistsQuery, dbManager.Connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("기존에 있는 부서로 업데이트하려합니다.새로운 부서로 업데이트하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UpdateUI();
                    return;
                }

                // 부서 테이블의 부서 이름 업데이트
                string updateDepartmentQuery = Query.GetInstance()
                            .update("부서")
                            .set($"부서이름 = '{newDepartmentName}'")
                            .where($"부서이름 = '{currentDepartmentName}'")
                            .exec();

                dbManager.ExecuteNonQueury(updateDepartmentQuery);

                MessageBox.Show($"부서 이름이 '{currentDepartmentName}'에서 '{newDepartmentName}'(으)로 성공적으로 업데이트되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDepartmentComboBox();
            }
            catch (Exception ex)
            {
                // 여기에 적절한 예외 처리 메시지를 추가합니다.
                MessageBox.Show("업데이트할 수 없습니다. 입력된 부서 이름을 확인하세요. 관리자에게 문의하거나 시스템 로그를 확인하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateUI();
                dbManager.CloseConnection();
            }

        }
        // 콤보박스 업데이트 메서드
        private void UpdateDepartmentComboBox()
        {
            dbManager.InitDBManager();
            try
            {
                string query = Query.GetInstance()
                            .select("부서이름")
                            .from("부서")
                            .exec();

                List<string> departments = dbManager.GetList(query, "부서이름");
                recent_department_list_combobox.Items.Clear();
                foreach (var department in departments)
                {
                    recent_department_list_combobox.Items.Add(department);
                }

                // 콤보박스의 선택을 새로운 부서 이름으로 설정하거나 초기화
                recent_department_list_combobox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dbManager.CloseConnection();
        }


        //부서명 삭제
        private void delete_depatment_name_btn_Click(object sender, EventArgs e)
        {
            if (delete_depatment_name_input_textbox.Text == "")
            {
                MessageBox.Show("부서를 입력해주세요.");
                return;
            }
            string departmentNameToDelete = delete_depatment_name_input_textbox.Text;

            dbManager.InitDBManager();

            try
            {
                // 부서 테이블에 부서명이 존재하는지 확인
                string checkDepartmentQuery = Query.GetInstance()
                            .select("COUNT(*)")
                            .from("부서")
                            .where($"부서이름 = '{departmentNameToDelete}'")
                            .exec();

                if (dbManager.IsDuplicated(checkDepartmentQuery))
                {
                    // 사원 테이블에 해당 부서명을 가진 사원이 존재하는지 확인
                    string checkEmployeeQuery = Query.GetInstance()
                                .select("COUNT(*)")
                                .from("사원")
                                .where($"부서이름 = '{departmentNameToDelete}'")
                                .exec();

                    if (dbManager.IsDuplicated(checkEmployeeQuery))
                    {
                        MessageBox.Show("사원의 부서를 다른 부서로 인사이동 시킨 후 삭제하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UpdateUI();
                    }
                    else
                    {
                        // 부서 테이블에서 부서명 삭제
                        string deleteDepartmentQuery = Query.GetInstance()
                                    .deleteFrom("부서")
                                    .where($"부서이름 = '{departmentNameToDelete}'")
                                    .exec();

                        dbManager.ExecuteNonQueury(deleteDepartmentQuery);
                        MessageBox.Show("부서명을 성공적으로 삭제했습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateUI();

                    }
                }
                else
                {
                    MessageBox.Show("존재하지 않는 부서입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //부서장을 수정하기 위해서 전체조회

        private void for_department_leader_searching_result_to_combobox_btn_Click(object sender, EventArgs e)
        {
            dbManager.InitDBManager();
            try
            {
                string query = Query.GetInstance()
                    .select("부서이름")
                    .from("부서")
                    .exec();

                List<string> departments = dbManager.GetList(query, "부서이름");
                recent_department_name_list_for_leader_searching_combobox.Items.Clear();
                foreach (var department in departments)
                {
                    recent_department_name_list_for_leader_searching_combobox.Items.Add(department);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void for_department_leader_insert_and_update_btn_Click(object sender, EventArgs e)
        {
            if (recent_department_name_list_for_leader_searching_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("부서를 선택해주세요.");
                return;
            }
            if (for_depatment_leader_input_employeeName_textBox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }
            string selectedDepartment = recent_department_name_list_for_leader_searching_combobox.SelectedItem.ToString();
            string newLeaderName = for_depatment_leader_input_employeeName_textBox.Text;

            dbManager.InitDBManager();

            try
            {

                // 현재 부서장 조회
                string checkLeaderQuery = Query.GetInstance()
                    .select("부서장이름")
                    .from("부서")
                    .where($"부서이름 = '{selectedDepartment}'")
                    .exec();

                MySqlCommand cmd = new MySqlCommand(checkLeaderQuery, dbManager.Connection);
                var currentLeaderName = cmd.ExecuteScalar();

                string message;
                string updateQuery;

                if (currentLeaderName == null || currentLeaderName == DBNull.Value)
                {
                    updateQuery = Query.GetInstance()
                      .update("부서")
                      .set($"부서장이름 = '{newLeaderName}'")
                      .where($"부서이름 = '{selectedDepartment}'")
                      .exec();

                    message = "부서장이 업데이트되었습니다.";

                }
                else
                {
                    // 부서장이 이미 있을 경우 부서장 정보 업데이트
                    updateQuery = Query.GetInstance()
                         .update("부서")
                         .set($"부서장이름 = '{newLeaderName}'")
                         .where($"부서이름 = '{selectedDepartment}'")
                         .exec();

                    message = "부서장이 업데이트되었습니다.";

                }

                dbManager.ExecuteNonQueury(updateQuery);
                MessageBox.Show(message, "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateUI();
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

        private void for_department_leader_delete_btn_Click(object sender, EventArgs e)
        {
            if (recent_department_name_list_for_leader_searching_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("부서를 선택해주세요.");
                return;
            }
            if (for_depatment_leader_input_employeeName_textBox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }
            string selectedDepartment = recent_department_name_list_for_leader_searching_combobox.SelectedItem.ToString();
            string enteredLeaderName = for_depatment_leader_input_employeeName_textBox.Text;

            dbManager.InitDBManager();

            try
            {
                // DB에서 해당 부서의 부서장 이름을 조회
                string leaderNameQuery = Query.GetInstance()
                            .select("부서장이름")
                            .from("부서")
                            .where($"부서이름 = '{selectedDepartment}'")
                            .exec();

                MySqlCommand cmd = new MySqlCommand(leaderNameQuery, dbManager.Connection);
                object result = cmd.ExecuteScalar();

                if (result != null && result.ToString() == enteredLeaderName)
                {
                    // 부서장 이름이 입력한 이름과 일치하면 부서장을 null로 업데이트
                    string deleteLeaderQuery = Query.GetInstance()
                                .update("부서")
                                .set("부서장이름 = NULL")
                                .where($"부서이름 = '{selectedDepartment}'")
                                .exec();

                    dbManager.ExecuteNonQueury(deleteLeaderQuery);
                    MessageBox.Show($"{enteredLeaderName} 부서장 직급 해제하였습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateUI();
                }
                else
                {
                    MessageBox.Show("부서장이 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateUI();
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

        private void DepartmentManagement_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
