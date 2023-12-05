using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Windows.Forms;
using K4os.Compression.LZ4.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DBP_TeamProject.Forms.WorkMaster;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using Google.Protobuf;

namespace DBP_TeamProject.Forms
{
    public partial class WorkUpdater : Form
    {
        private string userName;
        private TimeSpan workStartTime;
        private string workDate;
        private string dateOnly;

        public WorkUpdater()
        {
            InitializeComponent();
        }
        // [#0] 날짜 정보
        private void comboBox_date_DropDown(object sender, EventArgs e)
        {
            comboBox_date.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                                select("DISTINCT DATE_FORMAT(업무등록일자, '%Y-%m-%d') AS 날짜").
                                from("일일업무").
                                exec();
            Category.GetInstance().LoadComboBoxData(comboBox_date, query, "날짜");
        }
        // [#0] 등록자 정보

        private void comboBox_user_DropDown(object sender, EventArgs e)
        {
            comboBox_user.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                                select("DISTINCT 업무등록자").
                                from("일일업무").
                                exec();
            Category.GetInstance().LoadComboBoxData(comboBox_user, query, "업무등록자");
        }
        // [#0] 검색버튼 클릭
        private void button_search_Click(object sender, EventArgs e)
        {
            GetDataGridView();
        }
        private void AddCondition(ref string query, string value)
        {
            if (!string.IsNullOrEmpty(value))
                query += (" AND " + value);
        }
        public void GetDataGridView()
        {
            string dateValue = GetSelectedValue(comboBox_date);
            string keyValue = textBox_key.Text;
            string userValue = GetSelectedValue(comboBox_user);

            string query = Query.GetInstance()
                        .select("업무등록자, 대분류명, 중분류명, 소분류명, 업무등록일자, 업무시작시간, 업무종료시간, 비고")
                        .from("일일업무")
                        .where("1=1")
                        .exec();
            if (dateValue != "") // 1. 날짜별 분류
            {
                AddCondition(ref query, $"업무등록일자 = '{dateValue}'");
            }
            if (keyValue != "") // 2. 키워드별 분류
            {
                AddCondition(ref query,
                    $"(대분류명 LIKE '%{keyValue}%' OR " +
                    $"중분류명 LIKE '%{keyValue}%'  OR " +
                    $"소분류명 LIKE '%{keyValue}%' OR " +
                    $"비고 LIKE '%{keyValue}%')");  // 데이터가 포함된 문자열
            }
            if (userValue != "") // 3. 유저별 분류
            {
                AddCondition(ref query, $"업무등록자 = '{userValue}'");
            }

            try
            {
                DataTable dataTable = DBManager.GetInstance().InitDBManager().FindDataTable(query);
                dataGridView_search.DataSource = dataTable;
                dataGridView_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private string GetSelectedValue(ComboBox comboBox)
        {
            return (comboBox.SelectedIndex != -1) ? comboBox.SelectedItem.ToString() : string.Empty;
        }
        // [#1] 데이터 그리드 뷰 셀 클릭 이벤트
        private void dataGridView_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView_search.SelectedCells.Count > 0 && e.RowIndex != dataGridView_search.Rows.Count - 1)
            {

                int rowIndex = dataGridView_search.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_search.Rows[rowIndex]; // 선택된 행의 값을 가져오기.

                userName = selectedRow.Cells["업무등록자"].Value.ToString();
                label_workID.Text = userName;

                label_bigcategory.Text = selectedRow.Cells["대분류명"].Value.ToString();
                comboBox_midcategory.Text = selectedRow.Cells["중분류명"].Value.ToString();
                comboBox_smallcategory.Text = selectedRow.Cells["소분류명"].Value.ToString();
                textBox_memo.Text = selectedRow.Cells["비고"].Value.ToString();

                // 시작시간 및 종료시간 가져오기
                workStartTime = (TimeSpan)selectedRow.Cells["업무시작시간"].Value;
                TimeSpan startTime = workStartTime;
                TimeSpan endTime = (TimeSpan)selectedRow.Cells["업무종료시간"].Value;



                // 시작시간을 시간과 분으로 ComboBox에 설정
                comboBox_stime.Text = startTime.Hours.ToString("00"); // 2자리 수로 표시
                comboBox_smin.Text = startTime.Minutes.ToString("00");

                // 종료시간을 시간과 분으로 ComboBox에 설정
                comboBox_etime.Text = endTime.Hours.ToString("00"); // 2자리 수로 표시
                comboBox_emin.Text = endTime.Minutes.ToString("00");

                if (string.IsNullOrEmpty(selectedRow.Cells["업무등록일자"].Value.ToString()))
                {
                    return;
                }
                workDate = selectedRow.Cells["업무등록일자"].Value.ToString();
                DateTime parsedDate = DateTime.Parse(workDate);
                dateOnly = parsedDate.ToString("yyyy-MM-dd");


            }
            else
            {
                MessageBox.Show("선택된 셀이 없습니다.");
            }
        }

        // [#1] 중분류 드롭다운 
        private void comboBox_midcategory_DropDown(object sender, EventArgs e)
        {
            if (label_bigcategory.Text == "")
            {
                MessageBox.Show("수정할 데이터가 있는 행을 선택하세요.");
                return;
            }
            string bigcategoryName = label_bigcategory.Text;

            comboBox_midcategory.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                            select("중분류명").
                            from("분류_중분류").
                            where($"대분류ID IN (SELECT 대분류ID FROM 분류_대분류 WHERE 대분류명 = '{bigcategoryName}')").
                            exec();

            Category.GetInstance().LoadComboBoxData(comboBox_midcategory, query, "중분류명");
        }
        // [#1] 소분류 드롭다운  
        private void comboBox_smallcategory_DropDown(object sender, EventArgs e)
        {
            if (label_bigcategory.Text == "")
            {
                MessageBox.Show("수정할 데이터가 있는 행을 선택하세요.");
                return;
            }
            if (comboBox_midcategory.SelectedIndex == -1)
            {
                MessageBox.Show("중분류를 선택해주세요.");
                return;
            }
            string bigcategoryName = label_bigcategory.Text;
            int selectedBigCategoryID = GetBigID(bigcategoryName);

            string midcategoryName = comboBox_midcategory.SelectedItem.ToString();

            comboBox_smallcategory.Items.Clear();
            string query = Query.GetInstance().
                            select("소분류명").
                            from("분류_소분류").
                            where($"중분류ID IN (SELECT 중분류ID FROM 분류_중분류 WHERE 대분류ID={selectedBigCategoryID} AND 중분류명='{midcategoryName}')").
                            exec();
            Category.GetInstance().LoadComboBoxData(comboBox_smallcategory, query, "소분류명");
        }
        // [#1-1] 대분류 ID 받아오기
        public int GetBigID(string bigCategory)
        {
            int result = 0;
            try
            {
                string query = Query.GetInstance()
                        .select("대분류ID")
                        .from("분류_대분류")
                        .where($"대분류명='{bigCategory}'")
                        .exec();

                result = Int32.Parse(DBManager.GetInstance().InitDBManager().GetInfo(query));
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
        private void button_update_Click(object sender, EventArgs e)
        {
            string id = label_workID.Text;
            if (id == "")
            {
                MessageBox.Show("수정할 데이터가 있는 행을 선택하세요");
                return;
            }
            if (id != LoginedUser.getInstance().UserId)
            {
                MessageBox.Show("본인 업무만 수정할 수 있습니다.");
                return;
            }
            string big = label_bigcategory.Text;
            string mid = comboBox_midcategory.Text;
            string small = comboBox_smallcategory.Text;
            string comments = textBox_memo.Text;

            string stime = comboBox_stime.Text;
            string smin = comboBox_smin.Text;

            string etime = comboBox_etime.Text;
            string emin = comboBox_emin.Text;

            // TimeSpan 객체 생성
            TimeSpan startTimeSpan = new TimeSpan(int.Parse(stime), int.Parse(smin), 0);
            TimeSpan endTimeSpan = new TimeSpan(int.Parse(etime), int.Parse(emin), 0);


            if (endTimeSpan < startTimeSpan)
            {
                MessageBox.Show("업무 종료시간이 업무 시작시간보다 이릅니다. ");
                return;
            }

            // 기존 업무와 겹치는지 확인
            if (IsWorkPeriodOverlap(userName, startTimeSpan, endTimeSpan))
            {
                MessageBox.Show("이미 등록된 기간과 업무 시간이 겹칩니다. 다른 시간을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 겹치면 등록 중단
            }
            try
            {
                string query = Query.GetInstance().
                    update("일일업무").
                    set($"중분류명 = '{mid}', 소분류명 = '{small}', 비고 = '{comments}', 업무시작시간 = '{startTimeSpan}', 업무종료시간 = '{endTimeSpan}'").
                    where($"업무등록자='{userName}' AND 업무등록일자 = '{dateOnly}' AND 업무시작시간='{workStartTime}'").
                    exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                MessageBox.Show("일일업무 수정에 성공했습니다");

                workStartTime = startTimeSpan;
                GetDataGridView();
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
        private bool IsWorkPeriodOverlap(string userId, TimeSpan newStartTime, TimeSpan newEndTime)
        {
            // MySQL 연결 문자열
            string connectionString = DBManager.GetInstance().StrConn;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 기존 업무 기간 및 업무등록자 조회 쿼리 작성
                string query = Query.GetInstance().
                            select("업무시작시간, 업무종료시간").
                            from("일일업무").
                            where($"업무등록자 = '{userId}' AND 업무등록일자 = '{dateOnly}' AND 업무시작시간 != '{workStartTime}'").
                            exec();

                //MessageBox.Show(workStartTime.ToString());

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 기존 업무의 시작 시간과 종료 시간
                            TimeSpan existingStartTime = ((TimeSpan)reader["업무시작시간"]);
                            TimeSpan existingEndTime = ((TimeSpan)reader["업무종료시간"]);

                            //MessageBox.Show(existingStartTime.ToString());
                            //MessageBox.Show(existingEndTime.ToString());

                            // 새로운 업무와 겹치는지 확인
                            if (IsTimeOverlap(newStartTime, newEndTime, existingStartTime, existingEndTime))
                            {
                                return true; // 겹친다면 true 반환
                            }
                        }
                    }
                }
            }

            return false; // 겹치는 업무가 없다면 false 반환
        }

        // 두 기간이 겹치는지 확인하는 메서드
        private bool IsTimeOverlap(TimeSpan startTime1, TimeSpan endTime1, TimeSpan startTime2, TimeSpan endTime2)
        {
            return startTime1 < endTime2 && startTime2 < endTime1;
        }

    }
}