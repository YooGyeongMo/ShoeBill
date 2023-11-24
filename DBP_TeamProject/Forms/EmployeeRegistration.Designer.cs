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
            addressGroupBox = new GroupBox();
            loadAddressButton = new Button();
            addressTextBox = new TextBox();
            label41 = new Label();
            zipCodeTextBox = new TextBox();
            label42 = new Label();
            employeeGroupBox = new GroupBox();
            departmentComboBox = new ComboBox();
            rateComboBox = new ComboBox();
            birthdateTimePicker = new DateTimePicker();
            label37 = new Label();
            label38 = new Label();
            nameTextBox = new TextBox();
            label39 = new Label();
            label40 = new Label();
            loginGroupBox = new GroupBox();
            passwordTextBox = new TextBox();
            label43 = new Label();
            idTextBox = new TextBox();
            label44 = new Label();
            departmentPanel.SuspendLayout();
            employeeInputGroupBox.SuspendLayout();
            addressGroupBox.SuspendLayout();
            employeeGroupBox.SuspendLayout();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // departmentPanel
            // 
            departmentPanel.Controls.Add(saveEmployeeButton);
            departmentPanel.Controls.Add(employeeInputGroupBox);
            departmentPanel.Location = new Point(28, 17);
            departmentPanel.Margin = new Padding(4, 4, 4, 4);
            departmentPanel.Name = "departmentPanel";
            departmentPanel.Size = new Size(960, 617);
            departmentPanel.TabIndex = 11;
            // 
            // saveEmployeeButton
            // 
            saveEmployeeButton.Location = new Point(193, 408);
            saveEmployeeButton.Margin = new Padding(4, 4, 4, 4);
            saveEmployeeButton.Name = "saveEmployeeButton";
            saveEmployeeButton.Size = new Size(588, 61);
            saveEmployeeButton.TabIndex = 1;
            saveEmployeeButton.Text = "사원 등록";
            saveEmployeeButton.UseVisualStyleBackColor = true;
            saveEmployeeButton.Click += saveEmployeeButton_Click;
            // 
            // employeeInputGroupBox
            // 
            employeeInputGroupBox.Controls.Add(errorMsgLabel);
            employeeInputGroupBox.Controls.Add(addressGroupBox);
            employeeInputGroupBox.Controls.Add(employeeGroupBox);
            employeeInputGroupBox.Controls.Add(loginGroupBox);
            employeeInputGroupBox.Location = new Point(31, 17);
            employeeInputGroupBox.Margin = new Padding(4, 4, 4, 4);
            employeeInputGroupBox.Name = "employeeInputGroupBox";
            employeeInputGroupBox.Padding = new Padding(4, 4, 4, 4);
            employeeInputGroupBox.Size = new Size(901, 371);
            employeeInputGroupBox.TabIndex = 1;
            employeeInputGroupBox.TabStop = false;
            employeeInputGroupBox.Text = "사원 정보 입력";
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(24, 337);
            errorMsgLabel.Margin = new Padding(4, 0, 4, 0);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 20);
            errorMsgLabel.TabIndex = 12;
            // 
            // addressGroupBox
            // 
            addressGroupBox.Controls.Add(loadAddressButton);
            addressGroupBox.Controls.Add(addressTextBox);
            addressGroupBox.Controls.Add(label41);
            addressGroupBox.Controls.Add(zipCodeTextBox);
            addressGroupBox.Controls.Add(label42);
            addressGroupBox.Location = new Point(21, 188);
            addressGroupBox.Margin = new Padding(4, 4, 4, 4);
            addressGroupBox.Name = "addressGroupBox";
            addressGroupBox.Padding = new Padding(4, 4, 4, 4);
            addressGroupBox.Size = new Size(454, 140);
            addressGroupBox.TabIndex = 6;
            addressGroupBox.TabStop = false;
            addressGroupBox.Text = "주소 정보";
            // 
            // loadAddressButton
            // 
            loadAddressButton.Location = new Point(304, 81);
            loadAddressButton.Margin = new Padding(4, 4, 4, 4);
            loadAddressButton.Name = "loadAddressButton";
            loadAddressButton.Size = new Size(127, 31);
            loadAddressButton.TabIndex = 12;
            loadAddressButton.Text = "주소 불러오기";
            loadAddressButton.UseVisualStyleBackColor = true;
            loadAddressButton.Click += loadAddressButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Enabled = false;
            addressTextBox.Location = new Point(99, 43);
            addressTextBox.Margin = new Padding(4, 4, 4, 4);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(332, 27);
            addressTextBox.TabIndex = 3;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(55, 49);
            label41.Margin = new Padding(4, 0, 4, 0);
            label41.Name = "label41";
            label41.Size = new Size(39, 20);
            label41.TabIndex = 2;
            label41.Text = "주소";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Enabled = false;
            zipCodeTextBox.Location = new Point(99, 83);
            zipCodeTextBox.Margin = new Padding(4, 4, 4, 4);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(193, 27);
            zipCodeTextBox.TabIndex = 1;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(27, 90);
            label42.Margin = new Padding(4, 0, 4, 0);
            label42.Name = "label42";
            label42.Size = new Size(69, 20);
            label42.TabIndex = 0;
            label42.Text = "우편번호";
            // 
            // employeeGroupBox
            // 
            employeeGroupBox.Controls.Add(departmentComboBox);
            employeeGroupBox.Controls.Add(rateComboBox);
            employeeGroupBox.Controls.Add(birthdateTimePicker);
            employeeGroupBox.Controls.Add(label37);
            employeeGroupBox.Controls.Add(label38);
            employeeGroupBox.Controls.Add(nameTextBox);
            employeeGroupBox.Controls.Add(label39);
            employeeGroupBox.Controls.Add(label40);
            employeeGroupBox.ForeColor = SystemColors.WindowText;
            employeeGroupBox.Location = new Point(496, 41);
            employeeGroupBox.Margin = new Padding(4, 4, 4, 4);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Padding = new Padding(4, 4, 4, 4);
            employeeGroupBox.Size = new Size(375, 287);
            employeeGroupBox.TabIndex = 5;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "사원 정보";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "인사 부서", "개발 부서", "기획 부서" });
            departmentComboBox.Location = new Point(139, 220);
            departmentComboBox.Margin = new Padding(4, 4, 4, 4);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(154, 28);
            departmentComboBox.TabIndex = 14;
            // 
            // rateComboBox
            // 
            rateComboBox.FormattingEnabled = true;
            rateComboBox.Items.AddRange(new object[] { "일반 사원", "부서장", "사장" });
            rateComboBox.Location = new Point(139, 161);
            rateComboBox.Margin = new Padding(4, 4, 4, 4);
            rateComboBox.Name = "rateComboBox";
            rateComboBox.Size = new Size(154, 28);
            rateComboBox.TabIndex = 13;
            rateComboBox.DropDown += rateComboBox_DropDown;
            // 
            // birthdateTimePicker
            // 
            birthdateTimePicker.Location = new Point(139, 104);
            birthdateTimePicker.Margin = new Padding(4, 4, 4, 4);
            birthdateTimePicker.Name = "birthdateTimePicker";
            birthdateTimePicker.Size = new Size(211, 27);
            birthdateTimePicker.TabIndex = 12;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(95, 167);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(39, 20);
            label37.TabIndex = 10;
            label37.Text = "직급";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(64, 109);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(69, 20);
            label38.TabIndex = 8;
            label38.Text = "생년월일";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(139, 45);
            nameTextBox.Margin = new Padding(4, 4, 4, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(142, 27);
            nameTextBox.TabIndex = 7;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(62, 52);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new Size(74, 20);
            label39.TabIndex = 6;
            label39.Text = "사원 이름";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(59, 225);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new Size(74, 20);
            label40.TabIndex = 4;
            label40.Text = "부서 이름";
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(passwordTextBox);
            loginGroupBox.Controls.Add(label43);
            loginGroupBox.Controls.Add(idTextBox);
            loginGroupBox.Controls.Add(label44);
            loginGroupBox.Location = new Point(202, 41);
            loginGroupBox.Margin = new Padding(4, 4, 4, 4);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Padding = new Padding(4, 4, 4, 4);
            loginGroupBox.Size = new Size(273, 133);
            loginGroupBox.TabIndex = 2;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "로그인 정보";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(99, 77);
            passwordTextBox.Margin = new Padding(4, 4, 4, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(142, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(26, 84);
            label43.Margin = new Padding(4, 0, 4, 0);
            label43.Name = "label43";
            label43.Size = new Size(69, 20);
            label43.TabIndex = 2;
            label43.Text = "비밀번호";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(99, 39);
            idTextBox.Margin = new Padding(4, 4, 4, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(142, 27);
            idTextBox.TabIndex = 1;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(40, 45);
            label44.Margin = new Padding(4, 0, 4, 0);
            label44.Name = "label44";
            label44.Size = new Size(54, 20);
            label44.TabIndex = 0;
            label44.Text = "아이디";
            // 
            // EmployeeRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentPanel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EmployeeRegistration";
            Size = new Size(1014, 657);
            departmentPanel.ResumeLayout(false);
            employeeInputGroupBox.ResumeLayout(false);
            employeeInputGroupBox.PerformLayout();
            addressGroupBox.ResumeLayout(false);
            addressGroupBox.PerformLayout();
            employeeGroupBox.ResumeLayout(false);
            employeeGroupBox.PerformLayout();
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel departmentPanel;
        private Button saveEmployeeButton;
        private GroupBox employeeInputGroupBox;
        private GroupBox employeeGroupBox;
        private Label label37;
        private Label label38;
        private TextBox nameTextBox;
        private Label label39;
        private Label label40;
        private GroupBox loginGroupBox;
        private TextBox passwordTextBox;
        private Label label43;
        private TextBox idTextBox;
        private Label label44;
        private DateTimePicker birthdateTimePicker;
        private ComboBox rateComboBox;
        private GroupBox addressGroupBox;
        private Button loadAddressButton;
        public TextBox addressTextBox;
        private Label label41;
        public TextBox zipCodeTextBox;
        private Label label42;
        private Label errorMsgLabel;
        private ComboBox departmentComboBox;
    }
}
