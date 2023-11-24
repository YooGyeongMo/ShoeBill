using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBP_TeamProject.Forms.EmployeeManagement
{
    public partial class EmployeeModDel : UserControl
    {
        private string name = string.Empty;
        private bool flag = false; // 데이터 그리드 뷰를 클릭했을 때 true가 됨
        public EmployeeModDel()
        {
            InitializeComponent();
            deleteButton.ForeColor = System.Drawing.Color.Red;
        }
        private bool IsAnyTextBoxesEmpty(GroupBox groupBox)
        {
            // 그룹박스 안에 있는 모든 텍스트 박스
            var textBoxes = groupBox.Controls.OfType<TextBox>();

            // 텍스트 박스가 하나라도 비어있으면
            return textBoxes.Any(textBox => string.IsNullOrEmpty(textBox.Text));
        }
        private bool IsAnyComboBoxesEmpty(GroupBox groupBox) // 그룹 박스 안 콤보박스 비어있는
        {
            // 그룹박스 안에 있는 모든 콤보박스
            var comboBoxes = groupBox.Controls.OfType<ComboBox>();

            // 콤보박스가 하나라도 선택된 항목이 없으면
            return comboBoxes.Any(comboBox => comboBox.SelectedIndex == -1);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            idLabel.Text = "";
            currDepartmentLabel.Text = "";
            currRateLabel.Text = "";

            if (IsAnyTextBoxesEmpty(modGroupBox)) // 아이이 텍스트박스가 비어있으면
            {
                errorMsgLabel.Text = "사원 이름을 입력해주세요";
                errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                errorMsgLabel.Text = "";
                name = idTextBox.Text;

                string query = Query.GetInstance().
                    select("사원ID, 이름, 부서이름, 직급").
                    from("사원").
                    where($"이름='{name}'").
                    exec();

                DataTable dataTable = DBManager.GetInstance().InitDBManager().FindDataTable(query);

                memberdataGridView.DataSource = dataTable;
                memberdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBManager.GetInstance().CloseConnection();
            }
        }
        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (IsAnyComboBoxesEmpty(modGroupBox))
            {
                errMsg.Text = "수정할 부서와 직급을 선택해주세요";
                errMsg.ForeColor = System.Drawing.Color.Red;
            }
            else // 콤보박스가 비어있지 않다면
            {
                errMsg.Text = "";
                string deapartment = departmentComboBox.SelectedItem.ToString();
                string rate = rateComboBox.SelectedItem.ToString();

                string query = Query.GetInstance().
                    update("사원").
                    set($"부서이름 = '{deapartment}', 직급 = '{rate}'").
                    where($"이름='{name}'").
                    exec();

                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                DBManager.GetInstance().CloseConnection();

                MessageBox.Show("정보 수정에 성공했습니다");
            }
        }

        private void memberdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                flag = true;
                DataGridViewRow selectedRow = memberdataGridView.Rows[e.RowIndex];

                string memName = selectedRow.Cells["이름"].Value.ToString();
                string memID = selectedRow.Cells["사원ID"].Value.ToString();
                string departmentName = selectedRow.Cells["부서이름"].Value.ToString();
                string rate = selectedRow.Cells["직급"].Value.ToString();

                name = memName;
                idLabel.Text = memID;
                currDepartmentLabel.Text = departmentName;
                currRateLabel.Text = rate;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (name == "")
            {
                errorMsgLabel.Text = "사원 이름을 입력해주세요";
                errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (flag) // 데이터 그리드 뷰를 클릭했을 때
                {
                    // 삭제 확인을 위한 모달 창 표시
                    DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // 모달창에 예를 누르면 DB에서 사원 삭제
                    {
                        string query = Query.GetInstance().
                            deleteFrom("사원").
                            where($"이름='{name}'").
                            exec();
                        DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                        DBManager.GetInstance().CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("사원 정보를 선택해주세요.");
                }
            }
        }

        // 부서 이름 콤보박스 드롭 다운 이벤트 
        private void departmentComboBox_DropDown(object sender, EventArgs e)
        {
            List<string> departmentNames = new List<string>();

            departmentComboBox.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                            select("부서이름").
                            from("부서").
                            exec();
            departmentNames = DBManager.GetInstance().InitDBManager().GetList(query,"부서이름");
            DBManager.GetInstance().CloseConnection();

            departmentComboBox.Items.AddRange(departmentNames.ToArray());
        }
    }
}
