using MySql.Data.MySqlClient;

namespace DBP_TeamProject.Forms
{
    public partial class MasterDeleter : Form
    {

        private class DataItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public MasterDeleter()
        {
            InitializeComponent();

            // 폼 로드 시 테이블 데이터를 ComboBox에 표시
            LoadExistingData(comboBox_midcategory, "중분류ID", "중분류명", "분류_중분류");
            LoadExistingData(comboBox_smallcategory, "소분류ID", "소분류명", "분류_소분류");
        }

        private void LoadExistingData(ComboBox comboBox, string idColumnName, string nameColumnName, string tableName)
        {
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {idColumnName}, {nameColumnName} FROM s5585452.{tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem menuItem = new DataItem
                            {
                                ID = Convert.ToInt32(reader[idColumnName]),
                                Name = Convert.ToString(reader[nameColumnName])
                            };

                            comboBox.Items.Add(menuItem);
                        }
                    }
                }
            }

            comboBox.SelectedIndex = -1;
        }


        private void DeleteData(string tableName, string idColumnName, ComboBox comboBox)
        {
            dynamic selectedItem = comboBox.SelectedItem;

            if (selectedItem != null)
            {
                string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"DELETE FROM s5585452.{tableName} WHERE {idColumnName}=@ID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", selectedItem.ID);

                        command.ExecuteNonQuery();

                        MessageBox.Show("데이터가 성공적으로 삭제되었습니다.");

                        // 삭제 후 콤보박스에서 선택된 아이템 제거
                        comboBox.Items.Remove(selectedItem);
                        comboBox.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 아이템을 선택하세요.");
            }
        }

   
        private void button_deletemid_Click(object sender, EventArgs e)
        {
            DeleteData("분류_중분류", "중분류ID", comboBox_midcategory);
        }

        private void button_deletesmall_Click(object sender, EventArgs e)
        {
            DeleteData("분류_소분류", "소분류ID", comboBox_smallcategory);
        }
    }
}
