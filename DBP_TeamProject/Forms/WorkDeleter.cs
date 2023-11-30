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
using ComboBox = System.Windows.Forms.ComboBox;

namespace DBP_TeamProject.Forms
{
    public partial class WorkDeleter : Form
    {
        public WorkDeleter()
        {
            InitializeComponent();

            connection = new MySqlConnection("Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;");
            command = new MySqlCommand();

            LoadDateData();

            LoadUserData();
        }

        private DataTable dataTable;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

        private class DateData
        {
            public int ID { get; set; }
            public string time { get; set; }

            public override string ToString()
            {
                return time;
            }
        }


        private class UserData
        {
            public int ID { get; set; }
            public string user { get; set; }

            public override string ToString()
            {
                return user;
            }
        }
        private void LoadComboBoxData(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            try
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(Convert.ToString(reader[displayMember]));
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            comboBox.SelectedIndex = -1;
        }
        private void LoadDateData()
        {
            string query = "SELECT DISTINCT DATE_FORMAT(업무등록일자, '%Y-%m-%d') AS 날짜 FROM s5585452.일일업무";
            LoadComboBoxData(comboBox_date, query, "날짜", "날짜");
        }
        private void LoadUserData()
        {
            string query = "SELECT DISTINCT 업무등록자 FROM s5585452.일일업무";
            LoadComboBoxData(comboBox_user, query, "업무등록자", "업무등록자");
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
                query += $" AND 업무등록일자 = '{dateValue}'";
            if (!string.IsNullOrEmpty(keyValue))
                query += $" AND (업무등록일자 LIKE '%{keyValue}%' OR 대분류명 LIKE '%{keyValue}%' OR 중분류명 LIKE '%{keyValue}%' OR 소분류명 LIKE '%{keyValue}%' OR 업무등록자 LIKE '%{keyValue}%' OR 비고 LIKE '%{keyValue}%')";
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

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkDeleter_Load(object sender, EventArgs e)
        {
            dataGridView_search.DataSource = null;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // 확인 대화상자를 표시하여 사용자에게 삭제 여부를 묻습니다.
            DialogResult result = MessageBox.Show("선택한 항목을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 선택된 행의 인덱스를 가져옵니다.
                int selectedIndex = dataGridView_search.CurrentCell.RowIndex;

                // 선택된 행의 데이터를 가져옵니다.
                DataRowView selectedRow = (DataRowView)dataGridView_search.Rows[selectedIndex].DataBoundItem;

                // 선택된 행의 일일업무ID를 가져옵니다.
                int selectedWorkID = Convert.ToInt32(selectedRow["일일업무ID"]);

                // 데이터베이스 연결 및 삭제 쿼리 실행
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = $"DELETE FROM s5585452.일일업무 WHERE 일일업무ID = {selectedWorkID}";

                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                // 선택된 행을 데이터 그리드 뷰에서 제거합니다.
                dataGridView_search.Rows.RemoveAt(selectedIndex);

                // 삭제 완료 메시지 표시
                MessageBox.Show("항목이 성공적으로 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
