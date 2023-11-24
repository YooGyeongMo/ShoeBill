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
    public partial class AttendanceManagement : UserControl
    {

        private DBManager dbManager;

        private string query;

        private string id_input;
        private string name_output;

        public AttendanceManagement()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();
        }

        // [#1] 출근 버튼 클릭 이벤트
        private void GoToWork_btn_Click(object sender, EventArgs e)
        {
            dbManager.InitDBManager();
            try
            {
                id_input = Employee_ID_inputbox.Text;

                if (!LoginedUser.getInstance().UserId.Equals(id_input))  // 로그인 정보와 사용자 아이디가 일치하지 않는다면
                {
                    MessageBox.Show("본인 사번을 입력하세요.");
                    return;
                }

                // 데이터베이스에서 사원의 이름을 조회
                query = Query.GetInstance()
                             .select("이름, 직급")
                             .from("사원")
                             .where($"사원ID = '{id_input}'")
                             .exec();

                MySqlCommand cmd = new MySqlCommand(query, dbManager.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name_output = reader.GetString("이름");
                    string type_output = reader.GetString("직급");

                    HomeOrWork_Employee_name_Screen.Text = name_output;
                    HomeOrWork_Employee_Type_Screen.Text = type_output;
                    HomeOrWork_Employee_name_Screen.Visible = true;
                    HomeOrWork_Employee_Type_Screen.Visible = true;
                }
                else
                {
                    MessageBox.Show("해당 사원 ID가 존재하지 않습니다.");
                    return;
                }
                reader.Close();

                if (IsLeaveWork()) // 퇴근상태인지 확인
                {
                    InsertAttendanceInfoDB();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                //데이터베이스 연결종료.
                dbManager.Connection.Close();
            }

        }

        // [#1] 퇴근 상태인지 확인
        public bool IsLeaveWork()
        {
            string query = Query.GetInstance()
                                .select("*")
                                .from("출근부")
                                .where($"사원ID='{id_input}' AND 출근날짜 = CURDATE() AND 퇴근여부 = 'N'")
                                .exec();

            bool isDuplicated = dbManager.InitDBManager().IsDuplicated(query);

            if (isDuplicated)
            {
                MessageBox.Show("출근 중입니다.");
                return false;
            }
            return true;
        }
        // [#1] DB에 출근정보 저장
        public void InsertAttendanceInfoDB()
        {
            string insertQuery = Query.GetInstance()
                                          .insert("출근부 (사원ID, 출근날짜, 출근시간, 퇴근여부)")
                                          .values($"('{id_input}', CURDATE(), NOW(), 'N')")
                                          .exec();

            dbManager.ExecuteNonQueury(insertQuery);

            string attendence_Text = "님 출근하였습니다.";
            WorkOrHome_Screen.Text = attendence_Text;
            WorkOrHome_Screen.Visible = true;
        }

        private void Employee_ID_inputbox_Click(object sender, EventArgs e)
        {
            Employee_ID_inputbox.Text = "";
        }

        // [#2] 퇴근 버튼 클릭 이벤트
        private void GoHome_btn_Click(object sender, EventArgs e)
        {
            dbManager.InitDBManager();
            try
            {
                id_input = Employee_ID_inputbox.Text;

                if (!LoginedUser.getInstance().UserId.Equals(id_input))  // 로그인 정보와 사용자 아이디가 일치하지 않는다면
                {
                    MessageBox.Show("본인사번 입력하세요.");
                    return;
                }
                // 데이터베이스에서 사원의 이름을 조회
                query = Query.GetInstance()
                             .select("이름, 직급")
                             .from("사원")
                             .where($"사원ID = '{id_input}'")
                             .exec();

                MySqlCommand cmd = new MySqlCommand(query, dbManager.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name_output = reader.GetString("이름");
                    string type_output = reader.GetString("직급");

                    HomeOrWork_Employee_name_Screen.Text = name_output;
                    HomeOrWork_Employee_Type_Screen.Text = type_output;
                    HomeOrWork_Employee_name_Screen.Visible = true;
                    HomeOrWork_Employee_Type_Screen.Visible = true;
                }
                else
                {
                    MessageBox.Show("해당 사원 ID가 존재하지 않습니다.");
                    return;
                }
                reader.Close();

                InsertLeaveWorkInfoDB(); // DB에 퇴근정보 저장 

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                //데이터베이스 연결종료.
                dbManager.Connection.Close();
            }

        }
        // [#2] DB에 퇴근정보 저장 
        public void InsertLeaveWorkInfoDB()
        {
            string updateQuery = Query.GetInstance()
                          .update("출근부")
                          .set($"퇴근날짜 = NOW(), 퇴근시간 = (DATE_ADD(NOW(), INTERVAL 8 HOUR)), 퇴근여부='Y'")
                          .where($"사원ID = '{id_input}' AND 출근날짜 = CURDATE() AND 퇴근여부='N'")
                          .exec();

            dbManager.ExecuteNonQueury(updateQuery);

            string departure_Text = "퇴근하였습니다.";
            WorkOrHome_Screen.Text = departure_Text;
            WorkOrHome_Screen.Visible = true;
        }

        // [#3] 조회버튼 클릭 이벤트
        private void loadButton_Click(object sender, EventArgs e)
        {
            id_input = Employee_ID_inputbox.Text;
            // 데이터 그리드 뷰 갱신
            UpdateAttendanceGridView(id_input);
        }
        // [#3] 출퇴근 현황 조회
        private void UpdateAttendanceGridView(string id_input)
        {
            //24시간으로 표시해서 시간과 날짜별로 짤라서 표현
            query = Query.GetInstance()
                        .select("사원ID AS ID, DATE_FORMAT(출근날짜, '%Y-%m-%d') as 출퇴근날짜, " +
                        "DATE_FORMAT(출근시간, '%H:%i:%s') as 출근시간, " +
                        "DATE_FORMAT(퇴근시간, '%H:%i:%s') as 퇴근시간")
                        .from("출근부")
                        .where($"사원ID='{id_input}'")
                        .groupBy("사원ID, 출근날짜, 출근시간, 퇴근날짜, 퇴근시간")
                        .exec();

            DataTable dataTable = dbManager.InitDBManager().FindDataTable(query);

            AttendanceTime_GV.DataSource = dataTable;
            AttendanceTime_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendanceTime_GV.Visible = true;
        }
    }
}
