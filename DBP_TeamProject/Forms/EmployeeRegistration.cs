using GookBabProgram;
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
        private string age;
        private string rate;
        private string zipCode;
        private string addr;

        public EmployeeRegistration()
        {
            InitializeComponent();
        }
        public void GetTextBoxInfo()
        {
            id = idTextBox.Text;
            password = passwordTextBox.Text;
            department = departmentTextBox.Text;
            name = nameTextBox.Text;
            age = ageTextBox.Text;
            rate = rateTextBox.Text;
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
            else if (IsAnyTextBoxesEmpty(employeeGroupBox))
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
                            insert("사원 (사원ID, 비밀번호, 부서ID, 이름, 나이, 직급, 우편번호, 주소)").
                            values($"('{id}','{password}', '{department}','{name}','{age}','{rate}','{zipCode}','{addr}')").exec();
            DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
            DBManager.GetInstance().CloseConnection();
        }
    }
}
