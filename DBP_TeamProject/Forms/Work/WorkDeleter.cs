using DBP_TeamProject.Forms.WorkMaster;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DBP_TeamProject.Forms
{
    public partial class WorkDeleter : Form
    {
        private string userName = null;
        private TimeSpan workStartTime;
        private string workDate;
        private string dateOnly;
        public WorkDeleter()
        {
            InitializeComponent();
        }
        // [#1] 날짜 정보 기반 검색
        private void comboBox_date_DropDown(object sender, EventArgs e)
        {
            comboBox_date.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                                select("DISTINCT DATE_FORMAT(업무등록일자, '%Y-%m-%d') AS 날짜").
                                from("일일업무").
                                exec();
            Category.GetInstance().LoadComboBoxData(comboBox_date, query, "날짜");
        }
        // [#2] 등록자 정보 기반 검색
        private void comboBox_user_DropDown(object sender, EventArgs e)
        {
            comboBox_user.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                                select("DISTINCT 업무등록자").
                                from("일일업무").
                                exec();
            Category.GetInstance().LoadComboBoxData(comboBox_user, query, "업무등록자");
        }
        // [#3] 검색
        private void button_search_Click(object sender, EventArgs e)
        {
            GetDataGridView(); // 데이터그리드 뷰 출력
        }
        // [#3] 데이터그리드 뷰 출력
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
        private void AddCondition(ref string query, string value)
        {
            if (!string.IsNullOrEmpty(value))
                query += (" AND " + value);
        }
        private string GetSelectedValue(ComboBox comboBox)
        {
            return (comboBox.SelectedIndex != -1) ? comboBox.SelectedItem.ToString() : string.Empty;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName)) // 데이터그리드 뷰 셀 클릭을 안했을 시
            {
                MessageBox.Show("삭제할 데이터가 있는 행을 선택하세요.");
                return; 
            }

            try
            {
                string query = Query.GetInstance().
                                        deleteFrom("일일업무").
                                        where($"업무등록자='{userName}' AND 업무등록일자 = '{dateOnly}' AND 업무시작시간='{workStartTime}'").
                                        exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                MessageBox.Show("일일업무 삭제에 성공했습니다");
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

        private void dataGridView_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_search.SelectedCells.Count > 0 && e.RowIndex != dataGridView_search.Rows.Count - 1)
            {
                int rowIndex = dataGridView_search.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_search.Rows[rowIndex]; // 선택된 행의 값을 가져오기.

                userName = selectedRow.Cells["업무등록자"].Value.ToString();

                workDate = selectedRow.Cells["업무등록일자"].Value.ToString();
                DateTime parsedDate = DateTime.Parse(workDate);
                dateOnly = parsedDate.ToString("yyyy-MM-dd");


                // 시작시간 및 종료시간 가져오기
                workStartTime = (TimeSpan)selectedRow.Cells["업무시작시간"].Value;
                TimeSpan startTime = workStartTime;
            }
            else
            {
                MessageBox.Show("선택된 셀이 없습니다.");
            }
        }
    }
}
