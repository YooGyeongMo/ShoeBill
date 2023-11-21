using GookBabProgram;
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

        private void GoToWork_btn_Click(object sender, EventArgs e)
        {
            dbManager.InitDBManager();
            try
            {
                id_input = Employee_ID_inputbox.Text;
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

                // 현재 시간으로 출근 시간 기록
                // 출근 시간 기록
                DateTime currentTime = DateTime.Now;
                string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                string insertQuery = Query.GetInstance()
                                          .insert("출근부 (사원ID, 출근날짜, 출근시간)")
                                          .values($"('{id_input}', CURDATE(), '{formattedTime}')")
                                          .on_duplicate_key_update($"출근시간 = '{formattedTime}'")
                                          .exec();

                dbManager.ExecuteNonQueury(insertQuery);

                // 데이터 그리드 뷰 갱신
                UpdateAttendanceGridView();

                string attendence_Text = "출근하였습니다.";
                WorkOrHome_Screen.Text = attendence_Text;
                WorkOrHome_Screen.Visible = true;
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

        private void UpdateAttendanceGridView()
        {
            //24시간으로 표시해서 시간과 날짜별로 짤라서 표현

            query = Query.GetInstance()
                        .select("사원ID, DATE_FORMAT(출근날짜, '%Y-%m-%d') as 출근날짜, DATE_FORMAT(출근시간, '%H:%i:%s') as 출근시간")
                        .from("출근부")
                        .groupBy("사원ID, 출근날짜, 출근시간")
                        .exec();

            DataTable dataTable = dbManager.FindDataTable(query);
            AttendanceTime_GV.DataSource = dataTable;
            AttendanceTime_GV.Visible = true;
        }

        private void Employee_ID_inputbox_Click(object sender, EventArgs e)
        {
            Employee_ID_inputbox.Text = "";
        }

        private void GoHome_btn_Click(object sender, EventArgs e)
        {
            dbManager.InitDBManager();
            try
            {
                id_input = Employee_ID_inputbox.Text;
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

                // 현재 시간으로 퇴근 시간 기록
                //퇴근 시간 기록
                DateTime currentTime = DateTime.Now;
                string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                string updateQuery = Query.GetInstance()
                          .update("출근부")
                          .set($"퇴근날짜 = CURDATE(), 퇴근시간 = '{formattedTime}', 총근무시간 = TIMESTAMPDIFF(HOUR, 출근시간, '{formattedTime}')")
                          .where($"사원ID = '{id_input}' AND 출근날짜 = CURDATE()")
                          .exec();

                dbManager.ExecuteNonQueury(updateQuery);





                // 데이터 그리드 뷰 갱신
                UpdateGoHomeGridView();

                string departure_Text = "퇴근하였습니다.";
                WorkOrHome_Screen.Text = departure_Text;
                WorkOrHome_Screen.Visible = true;
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
        private void UpdateGoHomeGridView()
        {
          
            query = Query.GetInstance()
                        .select("사원ID, DATE_FORMAT(퇴근날짜, '%Y-%m-%d') as 퇴근날짜, DATE_FORMAT(퇴근시간, '%H:%i:%s') as 퇴근시간")
                        .from("출근부")
                        .groupBy("사원ID, 퇴근날짜, 퇴근시간")
                        .exec();

            DataTable dataTable = dbManager.FindDataTable(query);
            GoToHomeTime_GV.DataSource = dataTable;
            GoToHomeTime_GV.Visible = true;
        }



    }
}
