﻿using DBP_TeamProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
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
        private string level;
        private string department;
        public Login()
        {
            InitializeComponent();
        }
        public string getId()
        {
            return id;
        }
        //직급 받아오는것.
        public void Get_level()
        {
            string query = Query.GetInstance().
                select("직급").
                from("사원").
                where($"사원ID='{id}'").
                exec();
            string dbLevel = DBManager.GetInstance().InitDBManager().getLevel(query);
            DBManager.GetInstance().CloseConnection();

            LoginedUser.getInstance().Level = dbLevel;
        }
        // 부서 받아오는것.
        public void GetDepartment()
        {
            string query = Query.GetInstance().
                select("부서이름").
                from("사원").
                where($"사원ID='{id}'").
                exec();
            department = DBManager.GetInstance().InitDBManager().GetInfo(query);
            DBManager.GetInstance().CloseConnection();

            LoginedUser.getInstance().Department = department;
        }
        public void CheckPassword()
        {
            string query = Query.GetInstance().
                select("비밀번호, 직급").
                from("사원").
                where($"사원ID='{id}'").
                exec();

            (string dbPassword, string dbRate) = DBManager.GetInstance().InitDBManager().getPasswordAndRate(query);
            Debug.WriteLine(dbPassword);
            Debug.WriteLine(dbRate);
            DBManager.GetInstance().CloseConnection();

            if (dbPassword != null)
            {
                if (pwd.Equals(dbPassword))
                {
                    Get_level();
                    GetDepartment();
                    LoginedUser.getInstance().UserId = this.id;

                    MainForm main = new MainForm();
                    this.Hide(); // 현재 폼을 감춤
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.");
                }
                if (dbRate != "사장")
                {
                    FormPersonnel_Management pmFomr = new FormPersonnel_Management();
                    pmFomr.menuStrip.Items[0].Enabled = false;
                    pmFomr.menuStrip.Items[1].Enabled = false;
                    //FormPersonnel_Management.pmForm.menuStrip.Items[1].Enabled = false;
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

            if (id.Length != 0 && pwd.Length != 0)
            {
                CheckPassword();
                // Get_level();
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LoadManager) // 체크박스 상태
            {
                ReloadMemberRecord.Checked = true;
                UserNameTextBox.Text = Properties.Settings.Default.LoginIDSave;
                PasswordTextBox.Text = Properties.Settings.Default.LoginPWSave;
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReloadMemberRecord.Checked == false) // 체크 x
            {
                Properties.Settings.Default.LoadManager = false;
                Properties.Settings.Default.Save();
            }
            else // 체크 o
            {
                Properties.Settings.Default.LoadManager = true;
                Properties.Settings.Default.LoginIDSave = UserNameTextBox.Text;
                Properties.Settings.Default.LoginPWSave = PasswordTextBox.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
