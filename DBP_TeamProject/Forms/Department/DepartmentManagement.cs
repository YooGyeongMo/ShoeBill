﻿using MySql.Data.MySqlClient;
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
        string departmentName;
        string departmentNameToDelete;

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


            try
            {
                //중복 검사 쿼리
                string checkDuplicationQuery = Query.GetInstance()
                             .select("COUNT(*)")
                             .from("부서")
                             .where($"부서이름 = '{departmentName}'")
                             .exec();
                if (DBManager.GetInstance().InitDBManager().IsDuplicated(checkDuplicationQuery))
                {
                    MessageBox.Show("동일한 부서 이름이 이미 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 새 부서 추가 쿼리
                string insertQuery = Query.GetInstance()
                    .insert("부서 (부서이름)")
                    .values($"('{departmentName}')")
                    .exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(insertQuery);


                MessageBox.Show("부서가 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //분류 테이블 대분류명 중복체크
                string query = Query.GetInstance()
                                .select("COUNT(*)")
                                .from("분류_대분류")
                                .where($"대분류명 = '{departmentName}'")
                                .exec();

                if (DBManager.GetInstance().InitDBManager().IsDuplicated(query))
                {
                    MessageBox.Show("분류_대분류 테이블에 부서 이름이 이미 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insert = Query.GetInstance()
                                 .insert("분류_대분류 (대분류명)")
                                 .values($"('{departmentName}')")
                                 .exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(insert);

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
        }

        //부서명을 콤보박스에서 현재 존재하는 것을 선택한 후 수정쿼리 보내기 위한 버튼
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

            try
            {
                // 새로운 부서 이름이 이미 존재하는지 확인
                string checkNewDepartmentNameExistsQuery = Query.GetInstance()
                            .select("COUNT(*)")
                            .from("부서")
                            .where($"부서이름 = '{newDepartmentName}'")
                            .exec();

                MySqlCommand cmd = new MySqlCommand(checkNewDepartmentNameExistsQuery, DBManager.GetInstance().Connection);
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

                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(updateDepartmentQuery);

                MessageBox.Show($"부서 이름이 '{currentDepartmentName}'에서 '{newDepartmentName}'(으)로 성공적으로 업데이트되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DB분류테이블에 중복체크 후
                string checkNewDepartmentNameExistInCategoryQuery = Query.GetInstance()
                            .select("COUNT(*)")
                            .from("분류_대분류")
                            .where($"대분류명 = '{newDepartmentName}'")
                            .exec();

                MySqlCommand cmd1 = new MySqlCommand(checkNewDepartmentNameExistInCategoryQuery, dbManager.Connection);
                int count1 = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count > 0)
                {
                    UpdateUI();
                    return;
                }

                // 분류_대분류 테이블에 update
                string updateDepartmentCategoryQuery = Query.GetInstance()
                            .update("분류_대분류")
                            .set($"대분류명 = '{newDepartmentName}'")
                            .where($"대분류명 = '{currentDepartmentName}'")
                            .exec();

                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(updateDepartmentCategoryQuery);

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
                DBManager.GetInstance().CloseConnection();
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
            departmentNameToDelete = delete_depatment_name_input_textbox.Text;

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
                        DeleteBigCate(); // 대분류명 삭제
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
        // 대분류명 삭제
        public void DeleteBigCate()
        {
            try
            {
                string query = Query.GetInstance().
                                deleteFrom("분류_대분류").
                                where($"대분류명 = '{departmentNameToDelete}'").
                                exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                //MessageBox.Show("대분류가 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string selectedDepartment = recent_department_name_list_for_leader_searching_combobox.SelectedItem.ToString();
            string newLeaderName = for_depatment_leader_input_employeeName_textBox.Text;

            dbManager.InitDBManager();

            try
            {
                // 1. 현재 부서장 확인
                string currentLeaderQuery = Query.GetInstance()
                    .select("부서장이름")
                    .from("부서")
                    .where($"부서이름 = '{selectedDepartment}'")
                    .exec();

                MySqlCommand currentLeaderCmd = new MySqlCommand(currentLeaderQuery, dbManager.Connection);
                var currentLeader = currentLeaderCmd.ExecuteScalar();

                if (currentLeader != DBNull.Value && currentLeader.ToString() != newLeaderName)
                {
                    MessageBox.Show($"{selectedDepartment} 부서에 이미 부서장이 있습니다. 다른 부서장을 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (currentLeader != DBNull.Value && currentLeader.ToString() == newLeaderName)
                {
                    MessageBox.Show($"{selectedDepartment} 부서에 본인이 부서장입니다. 다른 부서를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. 임명될 사원의 현재 상태 확인
                string checkEmployeeQuery = Query.GetInstance()
                    .select("사원ID, 부서이름, 직급")
                    .from("사원")
                    .where($"이름 = '{newLeaderName}'")
                    .exec();

                MySqlCommand employeeCmd = new MySqlCommand(checkEmployeeQuery, dbManager.Connection);
                MySqlDataReader reader = employeeCmd.ExecuteReader();
                string currName = null;
                string currentDepartment = null;
                string currentRole = null;

                if (reader.Read())
                {
                    currName = reader["사원ID"].ToString();
                    currentDepartment = reader["부서이름"].ToString();
                    currentRole = reader["직급"].ToString();
                }

                reader.Close();

                if (currentRole == "부서장" && currentDepartment != selectedDepartment)
                {
                    MessageBox.Show("이미 다른 부서의 부서장입니다. 다른 사원을 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 선택된 부서가 사원이 속한 부서와 일치하지 않는 경우
                if (selectedDepartment != currentDepartment)
                {
                    MessageBox.Show("현재 선택한 부서와 사원이 속한 부서가 일치하지 않습니다. 부서이동 후 부서장 임명을 진행하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // 임명될 사원이 '일반 사원'이고, 선택된 부서에 현재 부서장이 없는 경우에만 부서장 임명
                if (currentRole == "일반 사원" && currentLeader == DBNull.Value)
                {
                    // 부서 테이블에서 부서장 업데이트
                    string updateDepartmentQuery = Query.GetInstance()
                        .update("부서")
                        .set($"부서장이름 = '{newLeaderName}'")
                        .where($"부서이름 = '{selectedDepartment}'")
                        .exec();
                    dbManager.ExecuteNonQueury(updateDepartmentQuery);

                    // 사원 테이블에서 해당 사원의 직급과 부서명 업데이트
                    string updateEmployeeQuery = Query.GetInstance()
                        .update("사원")
                        .set($"직급 = '부서장', 부서이름 = '{selectedDepartment}'")
                        .where($"이름 = '{newLeaderName}' AND 사원ID = '{currName}'") // 동명이인 예외처리
                        .exec();
                    dbManager.ExecuteNonQueury(updateEmployeeQuery);

                    MessageBox.Show($"{selectedDepartment} 부서에 새로운 부서장이 임명되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateUI();
                }
                else
                {
                    MessageBox.Show("부서장을 임명할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateUI();
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

                    // 사원 테이블에서 해당 사원의 직급을 '일반사원'으로 업데이트
                    string updateEmployeeRoleQuery = Query.GetInstance()
                                .update("사원")
                                .set("직급 = '일반 사원'")
                                .where($"이름 = '{enteredLeaderName}'")
                                .exec();

                    dbManager.ExecuteNonQueury(updateEmployeeRoleQuery);

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
