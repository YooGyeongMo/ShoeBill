namespace DBP_TeamProject
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            panel1 = new Panel();
            UserNameTextBox = new TextBox();
            UserNameErrorLabel = new Label();
            ReloadMemberRecord = new CheckBox();
            LoginButton = new Button();
            panel2 = new Panel();
            PasswordTextBox = new TextBox();
            PasswordErrorLabel = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "사원 아이디";
            // 
            // panel1
            // 
            panel1.Controls.Add(UserNameTextBox);
            panel1.Controls.Add(UserNameErrorLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(37, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 67);
            panel1.TabIndex = 4;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.ForeColor = SystemColors.WindowText;
            UserNameTextBox.Location = new Point(78, 16);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(171, 23);
            UserNameTextBox.TabIndex = 4;
            UserNameTextBox.Click += UserNameTextBox_Clicked;
            // 
            // UserNameErrorLabel
            // 
            UserNameErrorLabel.AutoSize = true;
            UserNameErrorLabel.Location = new Point(78, 47);
            UserNameErrorLabel.Name = "UserNameErrorLabel";
            UserNameErrorLabel.Size = new Size(0, 15);
            UserNameErrorLabel.TabIndex = 3;
            // 
            // ReloadMemberRecord
            // 
            ReloadMemberRecord.AutoSize = true;
            ReloadMemberRecord.Location = new Point(100, 181);
            ReloadMemberRecord.Name = "ReloadMemberRecord";
            ReloadMemberRecord.Size = new Size(162, 19);
            ReloadMemberRecord.TabIndex = 5;
            ReloadMemberRecord.Text = "재접속 시 사원 정보 기록";
            ReloadMemberRecord.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(99, 206);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(163, 40);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "로그인";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordTextBox);
            panel2.Controls.Add(PasswordErrorLabel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(37, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 66);
            panel2.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.ForeColor = SystemColors.WindowText;
            PasswordTextBox.Location = new Point(78, 16);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(171, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.Click += PasswordTextBox_Click;
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.AutoSize = true;
            PasswordErrorLabel.Location = new Point(78, 47);
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(0, 15);
            PasswordErrorLabel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 20);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "비밀번호";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 259);
            Controls.Add(panel2);
            Controls.Add(ReloadMemberRecord);
            Controls.Add(LoginButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "로그인";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private TextBox UserNameTextBox;
        private Label UserNameErrorLabel;
        private CheckBox ReloadMemberRecord;
        private Button LoginButton;
        private Panel panel2;
        private TextBox PasswordTextBox;
        private Label PasswordErrorLabel;
        private Label label3;
    }
}