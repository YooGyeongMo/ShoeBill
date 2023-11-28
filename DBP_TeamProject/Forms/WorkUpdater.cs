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

namespace DBP_TeamProject.Forms
{
    public partial class WorkUpdater : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";


        public WorkUpdater()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
            LoadExistingData(comboBox_bigcategory, "분류_대분류", "대분류ID", "대분류명");
            LoadExistingData(comboBox_midcategory, "분류_중분류", "중분류ID", "중분류명");
            LoadExistingData(comboBox_smallcategory, "분류_소분류", "소분류ID", "소분류명");
            LoadComboBoxData(comboBox_date, "일일업무", "일일업무ID", "업무등록시간");
            LoadComboBoxData(comboBox_user, "일일업무", "일일업무ID", "업무등록자");

            dataGridView_search.CellContentClick += dataGridView_search_CellContentClick;
        }

        private class DataItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private class UserData
        {
            public int ID { get; set; }
            public string User { get; set; }

            public override string ToString()
            {
                return User;
            }
        }

        private void InitializeDatabase()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadData()
        {
            LoadCategories(comboBox_bigcategory, "분류_대분류", "대분류ID", "대분류명");
            LoadCategories(comboBox_midcategory, "분류_중분류", "중분류ID", "중분류명");
            LoadCategories(comboBox_smallcategory, "분류_소분류", "소분류ID", "소분류명");
            LoadComboBoxData(comboBox_date, "일일업무", "일일업무ID", "업무등록시간");
            LoadComboBoxData(comboBox_user, "일일업무", "일일업무ID", "업무등록자");
        }

        private void LoadExistingData(ComboBox comboBox, string tableName, string idColumnName, string displayColumnName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT {idColumnName}, {displayColumnName} FROM s5585452.{tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(new DataItem
                            {
                                ID = Convert.ToInt32(reader[idColumnName]),
                                Name = Convert.ToString(reader[displayColumnName])
                            });
                        }
                    }
                }
            }

            comboBox.SelectedIndex = -1;
        }

        private void LoadCategories(ComboBox comboBox, string tableName, string idColumnName, string displayColumnName)
        {
            LoadExistingData(comboBox, tableName, idColumnName, displayColumnName);
        }


        private void LoadComboBoxData(ComboBox comboBox, string tableName, string idColumnName, string displayColumnName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT {idColumnName}, {displayColumnName} FROM s5585452.{tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(new UserData
                            {
                                ID = Convert.ToInt32(reader[idColumnName]),
                                User = Convert.ToString(reader[displayColumnName])
                            });
                        }
                    }
                }
            }

            comboBox.SelectedIndex = -1;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // 콤보박스에서 선택한 값을 가져옵니다.
            string dateValue = (comboBox_date.SelectedIndex != -1) ? comboBox_date.Text : string.Empty;
            string keyValue = textBox_key.Text;
            string userValue = (comboBox_user.SelectedIndex != -1) ? comboBox_user.Text : string.Empty;

            // 쿼리 생성
            string query = "SELECT * FROM s5585452.일일업무 WHERE 1=1";

            // 선택된 값이 있는 경우에만 조건을 추가
            if (!string.IsNullOrEmpty(dateValue))
                query += $" AND 업무등록시간 = '{dateValue}'";
            if (!string.IsNullOrEmpty(keyValue))
                query += $" AND (업무등록시간 LIKE '%{keyValue}%' OR 대분류명 LIKE '%{keyValue}%' OR 중분류명 LIKE '%{keyValue}%' OR 소분류명 LIKE '%{keyValue}%' OR 업무등록자 LIKE '%{keyValue}%' OR 비고 LIKE '%{keyValue}%')";
            if (!string.IsNullOrEmpty(userValue))
                query += $" AND 업무등록자 = '{userValue}'";

            // 데이터베이스 연결 및 쿼리 실행
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // 데이터그리드뷰에 결과 표시
                    dataGridView_search.DataSource = dataTable;
                }
            }
        }






        private void button_update_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Selected Rows Count: {dataGridView_search.SelectedRows.Count}");

            // UI 요소에서 수정된 데이터를 가져오기
            string updatedBigCategory = comboBox_bigcategory.Text;
            string updatedMidCategory = comboBox_midcategory.Text;
            string updatedSmallCategory = comboBox_smallcategory.Text;
            string updatedMemo = textBox_memo.Text;
            int updatedStartTimeHour = Convert.ToInt32(comboBox_stime.Text);
            int updatedStartTimeMin = Convert.ToInt32(comboBox_smin.Text);
            int updatedEndTimeHour = Convert.ToInt32(comboBox_etime.Text);
            int updatedEndTimeMin = Convert.ToInt32(comboBox_emin.Text);

            // 수정된 데이터를 데이터베이스에 업데이트하는 쿼리 작성
            string updateQuery = "UPDATE s5585452.일일업무 " +
                                 "SET 대분류명 = @대분류명, 중분류명 = @중분류명, " +
                                 "소분류명 = @소분류명, 비고 = @비고, " +
                                 "업무시작시간 = @업무시작시간, 업무종료시간 = @업무종료시간 " +
                                 "WHERE 일일업무ID = @selectedID";

            using (MySqlConnection updateConnection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, updateConnection))
                {
                    // 매개변수 추가
                    updateCommand.Parameters.AddWithValue("@대분류명", updatedBigCategory);
                    updateCommand.Parameters.AddWithValue("@중분류명", updatedMidCategory);
                    updateCommand.Parameters.AddWithValue("@소분류명", updatedSmallCategory);
                    updateCommand.Parameters.AddWithValue("@비고", updatedMemo);

                    // Start and End times
                    TimeSpan updatedStartTime = new TimeSpan(updatedStartTimeHour, updatedStartTimeMin, 0);
                    TimeSpan updatedEndTime = new TimeSpan(updatedEndTimeHour, updatedEndTimeMin, 0);

                    updateCommand.Parameters.AddWithValue("@업무시작시간", updatedStartTime);
                    updateCommand.Parameters.AddWithValue("@업무종료시간", updatedEndTime);

                    // 선택된 행의 일련번호(ID)를 가져와 매개변수로 추가
                    updateCommand.Parameters.AddWithValue("@selectedID", Convert.ToInt32(textBox_workID.Text));

                    updateConnection.Open();
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("데이터가 업데이트되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // 업데이트 후에는 다시 검색을 통해 DataGridView 업데이트
            button_search_Click(sender, e);
        }

        private void dataGridView_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_search.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_search.SelectedRows[0];

                // 선택된 데이터를 UI 요소에 표시
                comboBox_bigcategory.Text = selectedRow.Cells["대분류명"].Value.ToString();
                comboBox_midcategory.Text = selectedRow.Cells["중분류명"].Value.ToString();
                comboBox_smallcategory.Text = selectedRow.Cells["소분류명"].Value.ToString();
                textBox_memo.Text = selectedRow.Cells["비고"].Value.ToString();

                // 시작시간 및 종료시간 가져오기
                TimeSpan startTime = (TimeSpan)selectedRow.Cells["업무시작시간"].Value;
                TimeSpan endTime = (TimeSpan)selectedRow.Cells["업무종료시간"].Value;

                // 시작시간을 시간과 분으로 분리하여 ComboBox에 설정
                comboBox_stime.Text = startTime.Hours.ToString();
                comboBox_smin.Text = startTime.Minutes.ToString();

                // 종료시간을 시간과 분으로 분리하여 ComboBox에 설정
                comboBox_etime.Text = endTime.Hours.ToString();
                comboBox_emin.Text = endTime.Minutes.ToString();
            }
        }


        private void comboBox_bigcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_midcategory.SelectedIndex = -1;
            comboBox_smallcategory.SelectedIndex = -1;
            // 선택된 대분류가 없으면 종료
            if (comboBox_bigcategory.SelectedItem == null)
            {
                return;
            }

            // 선택된 대분류의 ID를 가져옴
            int selectedBigCategoryID = ((DataItem)comboBox_bigcategory.SelectedItem).ID;

            // 중분류를 로드  
            comboBox_midcategory.Items.Clear();
            LoadMidCategories(selectedBigCategoryID);
        }

        private void LoadMidCategories(int bigCategoryId)
        {
            // MySQL 연결 문자열
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;"; // 연결 문자열을 실제 MySQL 서버 정보로 변경

            // 기존 중분류 항목을 지우고 다시 로드
            comboBox_midcategory.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 선택된 대분류에 해당하는 중분류 로드 쿼리 작성
                string query = "SELECT 중분류ID, 중분류명 FROM s5585452.분류_중분류 WHERE 대분류ID = @대분류ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@대분류ID", bigCategoryId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem menuItem = new DataItem
                            {
                                ID = Convert.ToInt32(reader["중분류ID"]),
                                Name = Convert.ToString(reader["중분류명"])
                            };

                            comboBox_midcategory.Items.Add(menuItem);
                            // 선택된 아이템이 없도록 설정
                            comboBox_midcategory.SelectedIndex = -1;
                        }
                    }
                }
            }


        }

        private void comboBox_midcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_smallcategory.SelectedIndex = -1;

            // 선택된 대분류가 없으면 종료
            if (comboBox_midcategory.SelectedItem == null)
            {
                return;
            }

            // 선택된 중분류의 ID를 가져옴
            int selectedMidCategoryID = ((DataItem)comboBox_midcategory.SelectedItem).ID;

            // 소분류를 로드  
            comboBox_smallcategory.Items.Clear();
            LoadSmallCategories(selectedMidCategoryID);
        }

        private void LoadSmallCategories(int midCategoryId)
        {
            // MySQL 연결 문자열
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;"; // 연결 문자열을 실제 MySQL 서버 정보로 변경

            // 기존 소분류 항목을 지우고 다시 로드
            comboBox_smallcategory.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 선택된 중분류에 해당하는 소분류 로드 쿼리 작성
                string query = "SELECT 소분류ID, 소분류명 FROM s5585452.분류_소분류 WHERE 중분류ID = @중분류ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@중분류ID", midCategoryId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem menuItem = new DataItem
                            {
                                ID = Convert.ToInt32(reader["소분류ID"]),
                                Name = Convert.ToString(reader["소분류명"])
                            };

                            comboBox_smallcategory.Items.Add(menuItem);
                            // 선택된 아이템이 없도록 설정
                            comboBox_smallcategory.SelectedIndex = -1;
                        }
                    }
                }
            }


        }

        private void button_get_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = dataGridView_search.CurrentCell.RowIndex;

            // 선택된 행의 데이터를 가져옵니다.
            DataRowView selectedRow = (DataRowView)dataGridView_search.Rows[selectedIndex].DataBoundItem;

            // 선택된 행의 일일업무ID를 가져옵니다.
            int selectedWorkID = Convert.ToInt32(selectedRow["일일업무ID"]);

            textBox_workID.Text = selectedRow["일일업무ID"].ToString(); 
            

            // 텍스트박스에 입력된 일일업무ID 가져오기
            if (int.TryParse(textBox_workID.Text, out int selectedID))
            {
                // 데이터베이스 연결 및 쿼리 실행
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM s5585452.일일업무 WHERE 일일업무ID = {selectedID}";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // 결과가 있는 경우 UI 요소에 표시
                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];

                            // UI 요소에 표시
                            comboBox_bigcategory.Text = row["대분류명"].ToString();
                            comboBox_midcategory.Text = row["중분류명"].ToString();
                            comboBox_smallcategory.Text = row["소분류명"].ToString();
                            textBox_memo.Text = row["비고"].ToString();

                            // 시작시간 및 종료시간 가져오기
                            TimeSpan startTime = (TimeSpan)row["업무시작시간"];
                            TimeSpan endTime = (TimeSpan)row["업무종료시간"];

                            // 시작시간을 시간과 분으로 분리하여 ComboBox에 설정
                            comboBox_stime.Text = startTime.Hours.ToString();
                            comboBox_smin.Text = startTime.Minutes.ToString();

                            // 종료시간을 시간과 분으로 분리하여 ComboBox에 설정
                            comboBox_etime.Text = endTime.Hours.ToString();
                            comboBox_emin.Text = endTime.Minutes.ToString();
                        }
                        else
                        {
                            MessageBox.Show("해당 ID에 대한 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("올바른 숫자를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkUpdater_Load(object sender, EventArgs e)
        {
            dataGridView_search.DataSource = null;
        }

        private void dataGridView_search_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
