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

    public partial class MasterMaker : Form
    {
        public MasterMaker()
        {
            InitializeComponent();

            LoadExistingData(comboBox_bigcategory, "대분류ID", "대분류명", "분류_대분류");
            LoadExistingData(comboBox_midcategory, "중분류ID", "중분류명", "분류_중분류");
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



        

        private void button_addmid_Click(object sender, EventArgs e)
        {
            // 텍스트박스2에서 입력된 데이터 가져오기
            string inputData = textBox_mid.Text;

            // 선택된 대분류의 ID 가져오기
            int selectedBigCategoryId = -1;
            if (comboBox_bigcategory.SelectedItem != null)
            {
                DataItem selectedData = (DataItem)comboBox_bigcategory.SelectedItem;
                selectedBigCategoryId = selectedData.ID;

                // 선택된 대분류의 대분류명 가져오기
                string selectedBigCategoryName = selectedData.Name;
            }

            // 중분류를 분류_중분류 테이블에 추가하는 코드 작성
            if (!string.IsNullOrEmpty(inputData) && selectedBigCategoryId != -1)
            {

                // 선택된 대분류의 대분류명 가져오기
                string selectedBigCategoryName = ((DataItem)comboBox_bigcategory.SelectedItem).Name;

                // MySQL 연결 문자열
                string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // INSERT 쿼리 작성
                    string query = $"INSERT INTO s5585452.분류_중분류 (중분류명, 대분류ID, 대분류명) " +
                                   $"VALUES ('{inputData}', {selectedBigCategoryId}, '{selectedBigCategoryName}')";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("중분류가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 데이터 추가 후 중분류 콤보박스 다시 로드
                comboBox_bigcategory.SelectedIndex = -1;
                comboBox_bigcategory.Items.Clear();
                LoadExistingData(comboBox_bigcategory, "대분류ID", "대분류명", "분류_대분류");
       
                comboBox_midcategory.SelectedIndex = -1;
                comboBox_midcategory.Items.Clear();
                LoadExistingData(comboBox_midcategory, "중분류ID", "중분류명", "분류_중분류");
              
                // 텍스트박스 초기화
                textBox_mid.Text = "";
            }
        }

        private void button_addsmall_Click(object sender, EventArgs e)
        {

            string inputData = textBox_small.Text;


            int selectedmidCategoryId = -1;
            if (comboBox_midcategory.SelectedItem != null)
            {
                DataItem selectedData = (DataItem)comboBox_midcategory.SelectedItem;
                selectedmidCategoryId = selectedData.ID;

                // 선택된 대분류의 대분류명 가져오기
                string selectedMidCategoryName = selectedData.Name;
            }
           

            if (!string.IsNullOrEmpty(inputData) && selectedmidCategoryId != -1)
            {

                string selectedMidCategoryName = ((DataItem)comboBox_midcategory.SelectedItem).Name;


                string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

              

                    string query = $"INSERT INTO s5585452.분류_소분류 (소분류명, 소분류ID, 소분류명) " +
                            $"VALUES ('{inputData}', {selectedmidCategoryId}, '{selectedMidCategoryName}')";


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("소분류가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBox_bigcategory.SelectedIndex = -1;
                comboBox_bigcategory.Items.Clear();
                LoadExistingData(comboBox_bigcategory, "대분류ID", "대분류명", "분류_대분류");

                comboBox_midcategory.SelectedIndex = -1;
                comboBox_midcategory.Items.Clear();
                LoadExistingData(comboBox_midcategory, "중분류ID", "중분류명", "분류_중분류");
                textBox_small.Text = "";
            }
        }

        private void comboBox_bigcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 대분류의 ID를 가져와 label_bb에 출력
            if (comboBox_bigcategory.SelectedItem != null)
            {
                DataItem selectedData = (DataItem)comboBox_bigcategory.SelectedItem;
                label_big.Text = selectedData.ID.ToString();
            }
        }

        private void comboBox_midcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 중분류의 ID를 가져와 label_mm에 출력
            if (comboBox_midcategory.SelectedItem != null)
            {
                DataItem selectedData = (DataItem)comboBox_midcategory.SelectedItem;
                label_mid.Text = selectedData.ID.ToString();
            }
        }
    }
}