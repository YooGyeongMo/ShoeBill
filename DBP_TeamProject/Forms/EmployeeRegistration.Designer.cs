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
            employeeAddPanel = new Panel();
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
            employeeAddPanel.SuspendLayout();
            employeeInputGroupBox.SuspendLayout();
            addressGroupBox.SuspendLayout();
            employeeGroupBox.SuspendLayout();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // employeeAddPanel
            // 
            employeeAddPanel.Controls.Add(saveEmployeeButton);
            employeeAddPanel.Controls.Add(employeeInputGroupBox);
            employeeAddPanel.Location = new Point(22, 13);
            employeeAddPanel.Name = "employeeAddPanel";
            employeeAddPanel.Size = new Size(747, 463);
            employeeAddPanel.TabIndex = 11;
            // 
            // saveEmployeeButton
            // 
            saveEmployeeButton.Location = new Point(150, 306);
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
            employeeInputGroupBox.Controls.Add(addressGroupBox);
            employeeInputGroupBox.Controls.Add(employeeGroupBox);
            employeeInputGroupBox.Controls.Add(loginGroupBox);
            employeeInputGroupBox.Location = new Point(24, 13);
            employeeInputGroupBox.Name = "employeeInputGroupBox";
            employeeInputGroupBox.Size = new Size(701, 278);
            employeeInputGroupBox.TabIndex = 1;
            employeeInputGroupBox.TabStop = false;
            employeeInputGroupBox.Text = "사원 정보 입력";
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(19, 253);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 15);
            errorMsgLabel.TabIndex = 12;
            // 
            // addressGroupBox
            // 
            addressGroupBox.Controls.Add(loadAddressButton);
            addressGroupBox.Controls.Add(addressTextBox);
            addressGroupBox.Controls.Add(label41);
            addressGroupBox.Controls.Add(zipCodeTextBox);
            addressGroupBox.Controls.Add(label42);
            addressGroupBox.Location = new Point(16, 141);
            addressGroupBox.Name = "addressGroupBox";
            addressGroupBox.Size = new Size(353, 105);
            addressGroupBox.TabIndex = 6;
            addressGroupBox.TabStop = false;
            addressGroupBox.Text = "주소 정보";
            // 
            // loadAddressButton
            // 
            loadAddressButton.Location = new Point(236, 61);
            loadAddressButton.Name = "loadAddressButton";
            loadAddressButton.Size = new Size(99, 23);
            loadAddressButton.TabIndex = 12;
            loadAddressButton.Text = "주소 불러오기";
            loadAddressButton.UseVisualStyleBackColor = true;
            loadAddressButton.Click += loadAddressButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Enabled = false;
            addressTextBox.Location = new Point(77, 32);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(259, 23);
            addressTextBox.TabIndex = 3;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(43, 37);
            label41.Name = "label41";
            label41.Size = new Size(31, 15);
            label41.TabIndex = 2;
            label41.Text = "주소";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Enabled = false;
            zipCodeTextBox.Location = new Point(77, 62);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(151, 23);
            zipCodeTextBox.TabIndex = 1;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(21, 68);
            label42.Name = "label42";
            label42.Size = new Size(55, 15);
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
            employeeGroupBox.Location = new Point(386, 31);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Size = new Size(292, 215);
            employeeGroupBox.TabIndex = 5;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "사원 정보";
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "인사 부서", "개발 부서", "기획 부서" });
            departmentComboBox.Location = new Point(108, 165);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(121, 23);
            departmentComboBox.TabIndex = 14;
            departmentComboBox.DropDown += departmentComboBox_DropDown;
            // 
            // rateComboBox
            // 
            rateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rateComboBox.FormattingEnabled = true;
            rateComboBox.Items.AddRange(new object[] { "일반 사원", "부서장", "사장" });
            rateComboBox.Location = new Point(108, 121);
            rateComboBox.Name = "rateComboBox";
            rateComboBox.Size = new Size(121, 23);
            rateComboBox.TabIndex = 13;
            // 
            // birthdateTimePicker
            // 
            birthdateTimePicker.Location = new Point(108, 78);
            birthdateTimePicker.Name = "birthdateTimePicker";
            birthdateTimePicker.Size = new Size(165, 23);
            birthdateTimePicker.TabIndex = 12;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(74, 125);
            label37.Name = "label37";
            label37.Size = new Size(31, 15);
            label37.TabIndex = 10;
            label37.Text = "직급";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(50, 82);
            label38.Name = "label38";
            label38.Size = new Size(55, 15);
            label38.TabIndex = 8;
            label38.Text = "생년월일";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(108, 34);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(111, 23);
            nameTextBox.TabIndex = 7;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(48, 39);
            label39.Name = "label39";
            label39.Size = new Size(59, 15);
            label39.TabIndex = 6;
            label39.Text = "사원 이름";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(46, 169);
            label40.Name = "label40";
            label40.Size = new Size(59, 15);
            label40.TabIndex = 4;
            label40.Text = "부서 이름";
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(passwordTextBox);
            loginGroupBox.Controls.Add(label43);
            loginGroupBox.Controls.Add(idTextBox);
            loginGroupBox.Controls.Add(label44);
            loginGroupBox.Location = new Point(157, 31);
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
            Controls.Add(employeeAddPanel);
            Name = "EmployeeRegistration";
            Size = new Size(789, 493);
            employeeAddPanel.ResumeLayout(false);
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

        private Panel employeeAddPanel;
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
