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

namespace DBP_TeamProject
{
    public partial class WorkSearcher : Form
    {

        private MySqlConnection connection;
        private string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";


        public WorkSearcher()
        {
            InitializeComponent();

            InitializeConnection();

            LoadDateData();

            LoadUserData();
        }

        private void InitializeConnection()
        {
            connection = new MySqlConnection(connectionString);
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
            string dateValue = GetSelectedValue(comboBox_date);
            string keyValue = textBox_key.Text;
            string userValue = GetSelectedValue(comboBox_user);

            string query = "SELECT * FROM s5585452.일일업무 WHERE 1=1";

            AddCondition(ref query, "업무등록일자", dateValue);
            AddCondition(ref query, "(업무등록일자 LIKE '%{0}%' OR 대분류명 LIKE '%{0}%' OR 중분류명 LIKE '%{0}%' OR 소분류명 LIKE '%{0}%' OR 업무등록자 LIKE '%{0}%' OR 비고 LIKE '%{0}%')", keyValue);
            AddCondition(ref query, "업무등록자", userValue);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_search.DataSource = dataTable;
                }
            }
        }

        private void AddCondition(ref string query, string condition, string value)
        {
            if (!string.IsNullOrEmpty(value))
                query += $" AND {string.Format(condition, value)}";
        }

        private string GetSelectedValue(ComboBox comboBox)
        {
            return (comboBox.SelectedIndex != -1) ? comboBox.SelectedItem.ToString() : string.Empty;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkSearcher_Load(object sender, EventArgs e)
        {
            dataGridView_search.DataSource = null;
        }

    
    }
}
