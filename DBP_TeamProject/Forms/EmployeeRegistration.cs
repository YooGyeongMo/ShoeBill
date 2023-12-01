using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject.Forms
{
    public partial class EmployeeRegistration : UserControl
    {
        private string query;

        private string id;
        private string password;
        private string department;
        private string name;
        private string dateOnly;
        private string rate;
        private string zipCode;
        private string addr;

        public EmployeeRegistration()
        {
            InitializeComponent();
        }
        public void GetTextBoxInfo()
        {
            DateTime dt = birthdateTimePicker.Value.Date;
            dateOnly = dt.ToString("yyyy-MM-dd");

            id = idTextBox.Text;
            password = passwordTextBox.Text;

            name = nameTextBox.Text;
            rate = rateComboBox.Text;
            department = departmentComboBox.Text;

            zipCode = zipCodeTextBox.Text;
            addr = addressTextBox.Text;
        }
        private void saveEmployeeButton_Click(object sender, EventArgs e)
        {
            string stringErrorMsg = "";

            if (IsAnyTextBoxesEmpty(loginGroupBox))
            {
                stringErrorMsg = "로그인";
            }
            else if (IsAnyTextBoxesEmpty(employeeGroupBox) || IsAnyComboBoxesEmpty(employeeGroupBox))
            {
                stringErrorMsg = "사원";
            }
            else if (IsAnyTextBoxesEmpty(addressGroupBox))
            {
                stringErrorMsg = "주소";
            }
            else
            {
                GetTextBoxInfo(); // 텍스트 박스 정보 받기
                if (IsDuplicateId(id)) // DB의 ID 데이터 중복 검사
                {
                    errorMsgLabel.Text = "이미 존재하는 ID입니다.";
                    errorMsgLabel.ForeColor = System.Drawing.Color.Red;
                }
                else // 중복되지 않다면 
                {
                    errorMsgLabel.Text = "";
                    InsertDB(); // DB에 저장
                }
                return;
            }
            errorMsgLabel.Text = stringErrorMsg + "정보를 덜 입력하셨습니다.";
            errorMsgLabel.ForeColor = System.Drawing.Color.Red;
        }
        private bool IsAnyTextBoxesEmpty(GroupBox groupBox)
        {
            // 그룹박스 안에 있는 모든 텍스트 박스
            var textBoxes = groupBox.Controls.OfType<TextBox>();

            // 텍스트 박스가 하나라도 비어있으면
            return textBoxes.Any(textBox => string.IsNullOrEmpty(textBox.Text));
        }
        private bool IsAnyComboBoxesEmpty(GroupBox groupBox)
        {
            // 그룹박스 안에 있는 모든 콤보박스
            var comboBoxes = groupBox.Controls.OfType<ComboBox>();

            // 콤보박스가 하나라도 선택된 항목이 없으면
            return comboBoxes.Any(comboBox => comboBox.SelectedIndex == -1);
        }
        public bool IsDuplicateId(string id)
        {
            string query = Query.GetInstance().
                select("COUNT(*)").
                from("사원").
                where($"사원ID='{id}'").
                exec();
            bool isDup = DBManager.GetInstance().InitDBManager().GetId(query);
            DBManager.GetInstance().CloseConnection();
            return isDup;
        }
        public void InsertDB()
        {
            string query = Query.GetInstance().
                            insert("사원 (사원ID, 비밀번호, 부서이름, 이름, 생년월일, 직급, 우편번호, 주소)").
                            values($"('{id}','{password}', '{department}','{name}','{dateOnly}','{rate}','{zipCode}','{addr}')").exec();
            int isSave = DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
            if (isSave > 0)
            {
                MessageBox.Show("정보가 입력되었습니다.");
            }
            DBManager.GetInstance().CloseConnection();
        }

        private void loadAddressButton_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            // 모달로 폼을 열고, DialogResult를 확인하여 사용자가 폼을 어떻게 닫았는지 확인
            if (address.ShowDialog() == DialogResult.OK)
            {
                // 사용자가 OK 버튼을 눌렀을 때만 값을 가져와서 처리
                string road = address.Road;
                string zip = address.Zip;

                // 값 처리
                SetAddressText(road);
                SetZipCodeText(zip);
            }
        }
        public void SetAddressText(string txt)
        {
            addressTextBox.Text = txt;
        }
        public void SetZipCodeText(string txt)
        {
            zipCodeTextBox.Text = txt;
        }
        // 부서 이름 콤보박스 드롭 다운 이벤트 
        private void rateComboBox_DropDown(object sender, EventArgs e)
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
