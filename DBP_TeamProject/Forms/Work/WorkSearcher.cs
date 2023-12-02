using DBP_TeamProject.Forms.WorkMaster;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DBP_TeamProject
{
    public partial class WorkSearcher : Form
    {
        public WorkSearcher()
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
        private void button_search_Click(object sender, EventArgs e)
        {
            string dateValue = GetSelectedValue(comboBox_date);
            string keyValue = textBox_key.Text;
            string userValue = GetSelectedValue(comboBox_user);

            string query = Query.GetInstance()
                        .select("업무등록자, 대분류명, 중분류명, 소분류명, 업무등록일자, 업무시작시간, 업무종료시간, 비고")
                        .from("일일업무")
                        .where("1=1")
                        .exec();
            if (dateValue != "")
            {
                AddCondition(ref query, $"업무등록일자 = '{dateValue}'");
            }
            if (keyValue != "")
            {
                AddCondition(ref query, 
                    $"(대분류명 LIKE '%{keyValue}%' OR " + 
                    $"중분류명 LIKE '%{keyValue}%'  OR " +
                    $"소분류명 LIKE '%{keyValue}%' OR " +
                    $"비고 LIKE '%{keyValue}%')");  // 데이터가 포함된 문자열
            }
            if (userValue != "")
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

        private void WorkSearcher_Load(object sender, EventArgs e)
        {
            dataGridView_search.DataSource = null;
        }
    }
}
