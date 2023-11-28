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
    public partial class MasterUpdater : Form
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
       

        public MasterUpdater()
        {
            InitializeComponent();

            // 폼 로드 시 테이블 데이터를 ComboBox에 표시
            LoadExistingData(comboBox_bigcategory, "대분류ID", "대분류명", "분류_대분류");
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

   

        private void UpdateData(string tableName, string idColumnName, string valueColumnName, ComboBox comboBox, TextBox textBox)
        {
            dynamic selectedItem = comboBox.SelectedItem;

            if (selectedItem != null)
            {
                string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"UPDATE s5585452.{tableName} SET {valueColumnName}=@Value WHERE {idColumnName}=@ID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value", textBox.Text);
                        command.Parameters.AddWithValue("@ID", selectedItem.ID);

                        command.ExecuteNonQuery();

                        MessageBox.Show("데이터가 성공적으로 업데이트되었습니다.");
                    }
                }
            }
            else
            {
                MessageBox.Show("업데이트할 아이템을 선택하세요.");
            }
        }

        private void button_updatebig_Click(object sender, EventArgs e)
        {
            if (comboBox_bigcategory.SelectedItem != null)
            {
                UpdateData("분류_대분류", "대분류ID", "대분류명", comboBox_bigcategory, textBox_bigcategory);
                comboBox_bigcategory.SelectedIndex = -1;
                comboBox_bigcategory.Items.Clear();
                textBox_bigcategory.Text = " ";
                LoadExistingData(comboBox_midcategory, "대분류ID", "대분류명", "분류_대분류");
            }
            else
            {
                MessageBox.Show("대분류를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_updatemid_Click(object sender, EventArgs e)
        {
            if (comboBox_midcategory.SelectedItem != null)
            {
                UpdateData("분류_중분류", "중분류ID", "중분류명", comboBox_midcategory, textBox_midcategory);
                comboBox_bigcategory.SelectedIndex = -1;
                comboBox_bigcategory.Items.Clear();
                comboBox_midcategory.SelectedIndex = -1;
                comboBox_midcategory.Items.Clear();
                textBox_midcategory.Text = " ";
                LoadExistingData(comboBox_midcategory, "중분류ID", "중분류명", "분류_중분류");
            }
            else
            {
                MessageBox.Show("중분류를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_updatesmall_Click(object sender, EventArgs e)
        {
            if (comboBox_smallcategory.SelectedItem != null)
            {
                UpdateData("분류_소분류", "소분류ID", "소분류명", comboBox_smallcategory, textBox_smallcategory);
                comboBox_midcategory.SelectedIndex = -1;
                comboBox_midcategory.Items.Clear();
                comboBox_smallcategory.SelectedIndex = -1;
                comboBox_smallcategory.Items.Clear();
                textBox_smallcategory.Text = " ";
                LoadExistingData(comboBox_midcategory, "소분류ID", "소분류명", "분류_소분류");
            }
            else
            {
                MessageBox.Show("소분류를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
