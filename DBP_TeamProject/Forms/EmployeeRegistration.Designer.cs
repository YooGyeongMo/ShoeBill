namespace DBP_TeamProject.Forms
{
    partial class EmployeeRegistration : UserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            departmentPanel = new Panel();
            saveEmployeeButton = new Button();
            employeeInputGroupBox = new GroupBox();
            errorMsgLabel = new Label();
            employeeGroupBox = new GroupBox();
            rateTextBox = new TextBox();
            label37 = new Label();
            ageTextBox = new TextBox();
            label38 = new Label();
            nameTextBox = new TextBox();
            departmentTextBox = new TextBox();
            label39 = new Label();
            label40 = new Label();
            addressGroupBox = new GroupBox();
            addressTextBox = new TextBox();
            label41 = new Label();
            zipCodeTextBox = new TextBox();
            label42 = new Label();
            loginGroupBox = new GroupBox();
            passwordTextBox = new TextBox();
            label43 = new Label();
            idTextBox = new TextBox();
            label44 = new Label();
            departmentPanel.SuspendLayout();
            employeeInputGroupBox.SuspendLayout();
            employeeGroupBox.SuspendLayout();
            addressGroupBox.SuspendLayout();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // departmentPanel
            // 
            departmentPanel.Controls.Add(saveEmployeeButton);
            departmentPanel.Controls.Add(employeeInputGroupBox);
            departmentPanel.Location = new Point(8, 0);
            departmentPanel.Name = "departmentPanel";
            departmentPanel.Size = new Size(784, 399);
            departmentPanel.TabIndex = 11;
            // 
            // saveEmployeeButton
            // 
            saveEmployeeButton.Location = new Point(180, 328);
            saveEmployeeButton.Name = "saveEmployeeButton";
            saveEmployeeButton.Size = new Size(457, 46);
            saveEmployeeButton.TabIndex = 1;
            saveEmployeeButton.Text = "사원 등록";
            saveEmployeeButton.UseVisualStyleBackColor = true;
            saveEmployeeButton.Click += saveEmployeeButton_Click;
            // 
            // employeeInputGroupBox
            // 
            employeeInputGroupBox.Controls.Add(errorMsgLabel);
            employeeInputGroupBox.Controls.Add(employeeGroupBox);
            employeeInputGroupBox.Controls.Add(addressGroupBox);
            employeeInputGroupBox.Controls.Add(loginGroupBox);
            employeeInputGroupBox.Location = new Point(39, 12);
            employeeInputGroupBox.Name = "employeeInputGroupBox";
            employeeInputGroupBox.Size = new Size(696, 300);
            employeeInputGroupBox.TabIndex = 1;
            employeeInputGroupBox.TabStop = false;
            employeeInputGroupBox.Text = "사원 정보 입력";
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(19, 271);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 15);
            errorMsgLabel.TabIndex = 6;
            // 
            // employeeGroupBox
            // 
            employeeGroupBox.Controls.Add(rateTextBox);
            employeeGroupBox.Controls.Add(label37);
            employeeGroupBox.Controls.Add(ageTextBox);
            employeeGroupBox.Controls.Add(label38);
            employeeGroupBox.Controls.Add(nameTextBox);
            employeeGroupBox.Controls.Add(departmentTextBox);
            employeeGroupBox.Controls.Add(label39);
            employeeGroupBox.Controls.Add(label40);
            employeeGroupBox.ForeColor = SystemColors.WindowText;
            employeeGroupBox.Location = new Point(417, 31);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Size = new Size(242, 226);
            employeeGroupBox.TabIndex = 5;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "사원 정보";
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(100, 177);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(111, 23);
            rateTextBox.TabIndex = 11;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(66, 182);
            label37.Name = "label37";
            label37.Size = new Size(31, 15);
            label37.TabIndex = 10;
            label37.Text = "직급";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(100, 129);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(111, 23);
            ageTextBox.TabIndex = 9;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(66, 134);
            label38.Name = "label38";
            label38.Size = new Size(31, 15);
            label38.TabIndex = 8;
            label38.Text = "나이";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(100, 84);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(111, 23);
            nameTextBox.TabIndex = 7;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(100, 40);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(111, 23);
            departmentTextBox.TabIndex = 5;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(66, 89);
            label39.Name = "label39";
            label39.Size = new Size(31, 15);
            label39.TabIndex = 6;
            label39.Text = "이름";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(27, 45);
            label40.Name = "label40";
            label40.Size = new Size(71, 15);
            label40.TabIndex = 4;
            label40.Text = "부서 아이디";
            // 
            // addressGroupBox
            // 
            addressGroupBox.Controls.Add(addressTextBox);
            addressGroupBox.Controls.Add(label41);
            addressGroupBox.Controls.Add(zipCodeTextBox);
            addressGroupBox.Controls.Add(label42);
            addressGroupBox.Location = new Point(34, 152);
            addressGroupBox.Name = "addressGroupBox";
            addressGroupBox.Size = new Size(353, 105);
            addressGroupBox.TabIndex = 4;
            addressGroupBox.TabStop = false;
            addressGroupBox.Text = "주소 정보";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(77, 58);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(213, 23);
            addressTextBox.TabIndex = 3;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(43, 63);
            label41.Name = "label41";
            label41.Size = new Size(31, 15);
            label41.TabIndex = 2;
            label41.Text = "주소";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(77, 29);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(213, 23);
            zipCodeTextBox.TabIndex = 1;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(21, 33);
            label42.Name = "label42";
            label42.Size = new Size(55, 15);
            label42.TabIndex = 0;
            label42.Text = "우편번호";
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(passwordTextBox);
            loginGroupBox.Controls.Add(label43);
            loginGroupBox.Controls.Add(idTextBox);
            loginGroupBox.Controls.Add(label44);
            loginGroupBox.Location = new Point(34, 31);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(212, 100);
            loginGroupBox.TabIndex = 2;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "로그인 정보";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(77, 58);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(111, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(20, 63);
            label43.Name = "label43";
            label43.Size = new Size(55, 15);
            label43.TabIndex = 2;
            label43.Text = "비밀번호";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(77, 29);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(111, 23);
            idTextBox.TabIndex = 1;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(31, 34);
            label44.Name = "label44";
            label44.Size = new Size(43, 15);
            label44.TabIndex = 0;
            label44.Text = "아이디";
            // 
            // EmployeeRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentPanel);
            Name = "EmployeeRegistration";
            Size = new Size(800, 500);
            departmentPanel.ResumeLayout(false);
            employeeInputGroupBox.ResumeLayout(false);
            employeeInputGroupBox.PerformLayout();
            employeeGroupBox.ResumeLayout(false);
            employeeGroupBox.PerformLayout();
            addressGroupBox.ResumeLayout(false);
            addressGroupBox.PerformLayout();
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel departmentPanel;
        private Button saveEmployeeButton;
        private GroupBox employeeInputGroupBox;
        private Label errorMsgLabel;
        private GroupBox employeeGroupBox;
        private TextBox rateTextBox;
        private Label label37;
        private TextBox ageTextBox;
        private Label label38;
        private TextBox nameTextBox;
        private TextBox departmentTextBox;
        private Label label39;
        private Label label40;
        private GroupBox addressGroupBox;
        private TextBox addressTextBox;
        private Label label41;
        private TextBox zipCodeTextBox;
        private Label label42;
        private GroupBox loginGroupBox;
        private TextBox passwordTextBox;
        private Label label43;
        private TextBox idTextBox;
        private Label label44;
    }
}
