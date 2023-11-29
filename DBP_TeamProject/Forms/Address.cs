using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace DBP_TeamProject.Forms
{
    public partial class Address : Form
    {
        public string Road { get; set; }
        public string Zip { get; set; }


        string currentPage = "1";  //현재 페이지
        string countPerPage = "1000"; //1페이지당 출력 갯수
        string confmKey = "devU01TX0FVVEgyMDIzMTExNjE5MDk1NTExNDI4Mzg="; //테스트 Key
        string keyword = string.Empty;
        string apiurl = string.Empty;
        public Address()
        {
            InitializeComponent();
        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            if (roadAddrTextBox.Text == "")
            {
                MessageBox.Show("도로명 주소를 입력해주세요.");
                return;
            }

            try
            {
                string response;
                //keyword = textBox1.Text.Trim();
                apiurl = "https://business.juso.go.kr/addrlink/addrLinkApi.do?"
                    + currentPage + "&countPerPage="
                    + countPerPage + "&keyword="
                    + roadAddrTextBox.Text + "&confmKey=" + confmKey;

                using (HttpClient client = new HttpClient())
                {
                    // 비동기로 API 호출
                    response = await client.GetStringAsync(apiurl);
                }
                // XML을 DataSet으로 변환
                DataSet ds = new DataSet();
                using (StringReader stringReader = new StringReader(response))
                {
                    ds.ReadXml(stringReader);
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("도로명주소");
                dt.Columns.Add("우편번호");

                // Get the 'juso' table from the DataSet
                DataTable jusoTable = ds.Tables["juso"];

                // Check if the table exists in the DataSet
                if (jusoTable != null)
                {
                    // Iterate through each row in the 'juso' table
                    foreach (DataRow row in jusoTable.Rows)
                    {
                        // Get values from 'roadAddr' and 'zipNo' columns
                        string roadAddr = row["roadAddr"].ToString();
                        string zipNo = row["zipNo"].ToString();

                        // Add a new row to the DataTable
                        dt.Rows.Add(roadAddr, zipNo);
                    }
                }
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string roadAddr = selectedRow.Cells["도로명주소"].Value.ToString();
                string zipNo = selectedRow.Cells["우편번호"].Value.ToString();

                roadAddrTextBox.Text = roadAddr;
                zipCodeTextBox.Text = zipNo;
            }
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            // 값 설정
            Road = roadAddrTextBox.Text;
            Zip = zipCodeTextBox.Text;

            // DialogResult를 OK로 설정하여 폼을 닫음
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
