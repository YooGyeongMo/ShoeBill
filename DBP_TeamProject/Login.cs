using GookBabProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject
{
    public partial class Login : Form
    {
        private string id;
        private string pwd;
        public Login()
        {
            InitializeComponent();
        }
        public string getId()
        {
            return id;
        }
        public void CheckPassword()
        {
            string query = Query.GetInstance().
                select("비밀번호").
                from("사원").
                where($"사원ID='{id}'").
                exec();

            string dbPassword= DBManager.GetInstance().InitDBManager().GetPassword(query);
            Debug.WriteLine(dbPassword); 
            DBManager.GetInstance().CloseConnection();

            if (dbPassword != null)
            {
                if (pwd.Equals(dbPassword))
                {         
                    MainForm main = new MainForm();
                    this.Hide(); // 현재 폼을 감춤
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.");
                }
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            id = UserNameTextBox.Text;
            pwd = PasswordTextBox.Text;

            if (id.Length == 0)
            {
                UserNameErrorLabel.Text = "사원 이름을 입력하세요.";
                UserNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                UserNameErrorLabel.Text = "";
            }
            if (pwd.Length == 0)
            {
                PasswordErrorLabel.Text = "비밀번호를 입력하세요.";
                PasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                PasswordErrorLabel.Text = "";
            }

            if( id.Length != 0 && pwd.Length != 0 )
            {
                CheckPassword();
            }
        }
        private void UserNameTextBox_Clicked(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
        }
    }
}
