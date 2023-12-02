using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBP_TeamProject.Forms.SalaryManagement
{
    public partial class SalaryStatement : UserControl
    {
        private string id_input;

        private string workDate;

        private string overTime;
        private string nightTime;
        private string holidayTime;
        private string totalTime;

        public SalaryStatement()
        {
            InitializeComponent();
            InitializeDateTimePicker();

            if (LoginedUser.getInstance().Level != "관리자") // 관리자 이외 접근 불가
            {
                workTimeRegistPanel.Enabled = false;
            }
        }
        public void InitializeDateTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM";
        }

        // [#1] 야간 근로 시간 조회 버튼 클릭 이벤트 
        private void additWorkTimeLoadButton_Click(object sender, EventArgs e)
        {
            id_input = idTextBox.Text;

            DateTime date = dateTimePicker1.Value;
            string selectedDate = date.ToString("yyyy-MM");

            if (id_input == "")
            {
                MessageBox.Show("조회할 사번을 입력해주세요");
                return;
            }
            if (GetId(id_input))
            {
                NightTimeWorkInfo(id_input, selectedDate);
            }
            else
            {
                MessageBox.Show("등록된 사원이 없습니다.");
            }
        }
        // [#2] 휴일 근로 시간 계산
        private void HolidayTimeLoadButton_Click(object sender, EventArgs e)
        {
            id_input = idTextBox.Text;

            DateTime date = dateTimePicker1.Value;
            string selectedDate = date.ToString("yyyy-MM");

            if (id_input == "")
            {
                MessageBox.Show("조회할 사번을 입력해주세요");
                return;
            }
            if (GetId(id_input))
            {
                HolidayTimeWorkInfo(id_input, selectedDate);
            }
            else
            {
                MessageBox.Show("등록된 사원이 없습니다.");
            }
        }
        public bool GetId(string id_input)
        {
            string query = Query.GetInstance()
                       .select("*")
                       .from("출근부")
                       .where($"사원ID='{id_input}'")
                       .exec();

            bool result = DBManager.GetInstance().InitDBManager().GetId(query);

            return result;

        }
        // [#1] 야간 근로 시간 조회 
        public void NightTimeWorkInfo(string id_input, string selectedDate)
        {
            //24시간으로 표시해서 시간과 날짜별로 짤라서 표현
            string query = Query.GetInstance()
                        .select("사원ID AS ID, DATE_FORMAT(출근날짜, '%Y-%m-%d') as 출퇴근날짜, " +
                        "DATE_FORMAT(출근시간, '%H:%i:%s') as 출근시간, " +
                        "DATE_FORMAT(퇴근시간, '%H:%i:%s') as 퇴근시간")
                        .from("출근부")
                        .where($"사원ID='{id_input}' AND TIME(퇴근시간) > '17:00:00' AND DATE_FORMAT(출근날짜, '%Y-%m') = '{selectedDate}'")
                        .groupBy("사원ID, 출근날짜, 출근시간, 퇴근날짜, 퇴근시간")
                        .exec();

            DataTable dataTable = DBManager.GetInstance().InitDBManager().FindDataTable(query);
            AttendanceTime_GV.DataSource = dataTable;
            AttendanceTime_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendanceTime_GV.Visible = true;
            DBManager.GetInstance().CloseConnection();
        }
        // [#1] 휴일 근로 시간 조회 
        public void HolidayTimeWorkInfo(string id_input, string selectedDate)
        {
            //24시간으로 표시해서 시간과 날짜별로 짤라서 표현
            string query = Query.GetInstance()
                        .select("사원ID AS ID, DATE_FORMAT(출근날짜, '%Y-%m-%d') as 출퇴근날짜, " +
                        "DATE_FORMAT(출근시간, '%H:%i:%s') as 출근시간, " +
                        "DATE_FORMAT(퇴근시간, '%H:%i:%s') as 퇴근시간")
                        .from("출근부")
                        .where($"사원ID='{id_input}' AND DAYOFWEEK(출근날짜) IN (1, 7) AND DATE_FORMAT(출근날짜, '%Y-%m') = '{selectedDate}'")
                        .groupBy("사원ID, 출근날짜, 출근시간, 퇴근날짜, 퇴근시간")
                        .exec();

            DataTable dataTable = DBManager.GetInstance().InitDBManager().FindDataTable(query);
            AttendanceTime_GV.DataSource = dataTable;
            AttendanceTime_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendanceTime_GV.Visible = true;
            DBManager.GetInstance().CloseConnection();
        }
        // [#2] 근로 시간 계산
        private void calculateWorkTimeButton_Click(object sender, EventArgs e)
        {
            id_input = idTextBox.Text;

            DateTime date = dateTimePicker1.Value;
            string selectedDate = date.ToString("yyyy-MM");

            if (id_input == "")
            {
                MessageBox.Show("조회할 사번을 입력해주세요");
                return;
            }
            if (GetId(id_input))
            {
                totalTime = GetTotalWork(selectedDate); // [#2-0] 총 근로
                overTime = GetOverTimeWork(selectedDate); // [#2-1] 연장 근로
                nightTime = GetNightWork(selectedDate); // [#2-2] 야간 근로
                holidayTime = GetHolidayWork(selectedDate); // [#2-3] 휴일 근로  
            }
            else
            {
                MessageBox.Show("등록된 사원이 없습니다.");
            }
        }
        // [#2-0] 총 근로 
        public string GetTotalWork(string selectedDate)
        {
            string result = null;
            try
            {
                string query = Query.GetInstance()
                    .select("SUM(HOUR(TIMEDIFF(퇴근시간, 출근시간))) AS 총근무시간")
                    .from("출근부")
                    .where($"사원ID = '{id_input}' AND DATE_FORMAT(출근날짜, '%Y-%m') = '{selectedDate}'")
                    .exec();
                result = DBManager.GetInstance().InitDBManager().GetInfo(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            return result;
        }
        // [#2-1] 연장 근로
        public string GetOverTimeWork(string selectedDate)
        {
            string result = null;
            try
            {
                string query = Query.GetInstance()
                    .select("SUM(HOUR(TIMEDIFF(퇴근시간, 출근시간))) AS 총초과근무시간")
                    .from("출근부")
                    .where($"사원ID = '{id_input}' AND DATE_FORMAT(출근날짜, '%Y-%m') = '{selectedDate}'")
                    .exec();

                result = DBManager.GetInstance().InitDBManager().GetInfo(query);

                if (result == "")
                {
                    MessageBox.Show("결과값이 없습니다.");
                }
                else
                {
                    // 법정 근로시간
                    int legalWorkingHours = 160;
                    // 결과에서 법정 근로시간을 뺀 값을 계산
                    int overtimeHours = Convert.ToInt32(result) - legalWorkingHours;
                    result = overtimeHours.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }

            overTimeWork.Text = result;
            overTimeWork.ForeColor = Color.Blue;

            return result;
        }
        // [#2-2] 야간 근로
        public string GetHolidayWork(string selectedDate)
        {
            string result = null;
            try
            {
                string query = Query.GetInstance()
                        .select("SUM(HOUR(TIMEDIFF(퇴근시간, 출근시간))) AS 총초과근무시간")
                        .from("출근부")
                        .where($"사원ID='{id_input}' AND DAYOFWEEK(출근날짜) IN (1, 7) AND DATE_FORMAT(출근날짜, '%Y-%m') = '{selectedDate}'")
                        .exec();

                result = DBManager.GetInstance().InitDBManager().GetInfo(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }

            holidayWork.Text = result;
            holidayWork.ForeColor = Color.Blue;

            return result;
        }
        // [#2-3] 휴일 근로
        public string GetNightWork(string selectedDate)
        {
            string result = null;
            try
            {
                string query = Query.GetInstance()
                        .select("SUM(HOUR(TIMEDIFF(TIME(퇴근시간), '17:00:00'))) AS 총초과근무시간")
                        .from("출근부")
                        .where($"사원ID='{id_input}' AND TIME(퇴근시간) > '17:00:00' AND DATE_FORMAT(출근날짜, '%Y-%m') = '{selectedDate}'")
                        .exec();

                result = DBManager.GetInstance().InitDBManager().GetInfo(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            nightWork.Text = result;
            nightWork.ForeColor = Color.Blue;

            return result;
        }
        // [#3] 근로시간 등록 버튼 클릭 이벤트
        private void salarySaveButton_Click(object sender, EventArgs e)
        {
            if (AreAllLabelsEmpty(additWorkGroupBox)) // 라벨의 값이 있는지 검사
            {
                if (!IsDuplicateId(id_input))
                {
                    SaveAdditSalaryTable(id_input, totalTime, overTime, nightTime, holidayTime); // [#3] 추가 수당 정보 입력
                    //MessageBox.Show("추가수당이 저장되었습니다!");
                }
                else
                    MessageBox.Show("추가 수당이 이미 입력되어있습니다.");
            }
            else
                MessageBox.Show("추가근로 시간을 계산해주세요!");
        }

        public bool AreAllLabelsEmpty(GroupBox groupBox)
        {
            // 그룹박스 안에 있는 모든 라벨
            var labels = groupBox.Controls.OfType<Label>();
            return !labels.Any(label => string.IsNullOrEmpty(label.Text));
        }
        // [#3] DB에 저장
        public void SaveAdditSalaryTable(string id_input, string totalTime, string overTime, string nightTime, string holidayTime)
        {
            DateTime date = dateTimePicker1.Value;
            string selectedDate = date.ToString("yyyy-MM");

            string query = Query.GetInstance().
                            insert("근로시간 (사원ID, 근로일자, 총근로시간, 연장근로시간, 야간근로시간, 휴일근로시간)").
                            values($"('{id_input}','{selectedDate}','{totalTime}','{overTime}','{nightTime}','{holidayTime}')").
                            exec();

            int isSave = DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
            if (isSave > 0)
            {
                MessageBox.Show("정보가 입력되었습니다.");
            }
            DBManager.GetInstance().CloseConnection();
        }
        public bool IsDuplicateId(string id)
        {
            DateTime date = dateTimePicker1.Value;
            string selectedDate = date.ToString("yyyy-MM");

            string query = Query.GetInstance().
                select("COUNT(*)").
                from("근로시간").
                where($"사원ID='{id_input}' AND 근로일자='{selectedDate}'").
                exec();
            bool isDup = DBManager.GetInstance().InitDBManager().GetId(query);
            DBManager.GetInstance().CloseConnection();
            return isDup;
        }


    }
}
