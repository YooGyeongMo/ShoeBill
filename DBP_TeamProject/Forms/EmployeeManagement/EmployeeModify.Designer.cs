namespace DBP_TeamProject.Forms.EmployeeManagement
{
    partial class EmployeeModDel
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
            modGroupBox = new GroupBox();
            deleteButton = new Button();
            errMsg = new Label();
            currRateLabel = new Label();
            label9 = new Label();
            currDepartmentLabel = new Label();
            label7 = new Label();
            rateComboBox = new ComboBox();
            idLabel = new Label();
            label2 = new Label();
            modifyButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            departmentComboBox = new ComboBox();
            errorMsgLabel = new Label();
            idTextBox = new TextBox();
            label1 = new Label();
            loadButton = new Button();
            memberdataGridView = new DataGridView();
            departmentPanel.SuspendLayout();
            modGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberdataGridView).BeginInit();
            SuspendLayout();
            // 
            // departmentPanel
            // 
            departmentPanel.Controls.Add(modGroupBox);
            departmentPanel.Location = new Point(28, 28);
            departmentPanel.Margin = new Padding(4, 4, 4, 4);
            departmentPanel.Name = "departmentPanel";
            departmentPanel.Size = new Size(960, 617);
            departmentPanel.TabIndex = 13;
            // 
            // modGroupBox
            // 
            modGroupBox.Controls.Add(deleteButton);
            modGroupBox.Controls.Add(errMsg);
            modGroupBox.Controls.Add(currRateLabel);
            modGroupBox.Controls.Add(label9);
            modGroupBox.Controls.Add(currDepartmentLabel);
            modGroupBox.Controls.Add(label7);
            modGroupBox.Controls.Add(rateComboBox);
            modGroupBox.Controls.Add(idLabel);
            modGroupBox.Controls.Add(label2);
            modGroupBox.Controls.Add(modifyButton);
            modGroupBox.Controls.Add(label3);
            modGroupBox.Controls.Add(label4);
            modGroupBox.Controls.Add(label5);
            modGroupBox.Controls.Add(departmentComboBox);
            modGroupBox.Controls.Add(errorMsgLabel);
            modGroupBox.Controls.Add(idTextBox);
            modGroupBox.Controls.Add(label1);
            modGroupBox.Controls.Add(loadButton);
            modGroupBox.Controls.Add(memberdataGridView);
            modGroupBox.Location = new Point(50, 4);
            modGroupBox.Margin = new Padding(4, 4, 4, 4);
            modGroupBox.Name = "modGroupBox";
            modGroupBox.Padding = new Padding(4, 4, 4, 4);
            modGroupBox.Size = new Size(869, 449);
            modGroupBox.TabIndex = 15;
            modGroupBox.TabStop = false;
            modGroupBox.Text = "사원 수정/삭제";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(743, 21);
            deleteButton.Margin = new Padding(4, 4, 4, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(118, 51);
            deleteButton.TabIndex = 38;
            deleteButton.Text = "삭제하기";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // errMsg
            // 
            errMsg.AutoSize = true;
            errMsg.Location = new Point(262, 407);
            errMsg.Margin = new Padding(4, 0, 4, 0);
            errMsg.Name = "errMsg";
            errMsg.Size = new Size(0, 20);
            errMsg.TabIndex = 37;
            // 
            // currRateLabel
            // 
            currRateLabel.AutoSize = true;
            currRateLabel.ForeColor = SystemColors.HotTrack;
            currRateLabel.Location = new Point(143, 404);
            currRateLabel.Margin = new Padding(4, 0, 4, 0);
            currRateLabel.Name = "currRateLabel";
            currRateLabel.Size = new Size(0, 20);
            currRateLabel.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 404);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 35;
            label9.Text = "현재 직급";
            // 
            // currDepartmentLabel
            // 
            currDepartmentLabel.AutoSize = true;
            currDepartmentLabel.ForeColor = SystemColors.HotTrack;
            currDepartmentLabel.Location = new Point(143, 368);
            currDepartmentLabel.Margin = new Padding(4, 0, 4, 0);
            currDepartmentLabel.Name = "currDepartmentLabel";
            currDepartmentLabel.Size = new Size(0, 20);
            currDepartmentLabel.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 368);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 33;
            label7.Text = "현재 부서";
            // 
            // rateComboBox
            // 
            rateComboBox.FormattingEnabled = true;
            rateComboBox.Items.AddRange(new object[] { "일반 사원", "부서장", "사장" });
            rateComboBox.Location = new Point(590, 332);
            rateComboBox.Margin = new Padding(4, 4, 4, 4);
            rateComboBox.Name = "rateComboBox";
            rateComboBox.Size = new Size(136, 28);
            rateComboBox.TabIndex = 32;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = SystemColors.HotTrack;
            idLabel.Location = new Point(143, 333);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 20);
            idLabel.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(50, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 30;
            label2.Text = "수정/삭제할 사원을 선택하세요.";
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(730, 383);
            modifyButton.Margin = new Padding(4, 4, 4, 4);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(118, 51);
            modifyButton.TabIndex = 29;
            modifyButton.Text = "수정하기";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 337);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 27;
            label3.Text = "수정할 직급";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 25;
            label4.Text = "사원 아이디";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 336);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 24;
            label5.Text = "수정할 부서";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "인사 부서 ", "개발 부서 ", "기획 부서" });
            departmentComboBox.Location = new Point(354, 331);
            departmentComboBox.Margin = new Padding(4, 4, 4, 4);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(130, 28);
            departmentComboBox.TabIndex = 23;
            departmentComboBox.DropDown += departmentComboBox_DropDown;
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(126, 93);
            errorMsgLabel.Margin = new Padding(4, 0, 4, 0);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 20);
            errorMsgLabel.TabIndex = 22;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(126, 47);
            idTextBox.Margin = new Padding(4, 4, 4, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(127, 27);
            idTextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 18;
            label1.Text = "사원 이름";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(285, 48);
            loadButton.Margin = new Padding(4, 4, 4, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(150, 31);
            loadButton.TabIndex = 15;
            loadButton.Text = "수정할 사원 검색";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // memberdataGridView
            // 
            memberdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberdataGridView.Location = new Point(50, 164);
            memberdataGridView.Margin = new Padding(4, 4, 4, 4);
            memberdataGridView.Name = "memberdataGridView";
            memberdataGridView.RowHeadersWidth = 51;
            memberdataGridView.RowTemplate.Height = 25;
            memberdataGridView.Size = new Size(590, 133);
            memberdataGridView.TabIndex = 14;
            memberdataGridView.CellClick += memberdataGridView_CellClick;
            // 
            // EmployeeModDel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentPanel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EmployeeModDel";
            Size = new Size(1017, 672);
            departmentPanel.ResumeLayout(false);
            modGroupBox.ResumeLayout(false);
            modGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memberdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel departmentPanel;
        private GroupBox modGroupBox;
        private Label errorMsgLabel;
        private TextBox idTextBox;
        private Label label1;
        private Button loadButton;
        private DataGridView memberdataGridView;
        private Button modifyButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox departmentComboBox;
        private Label label2;
        private Label idLabel;
        private ComboBox rateComboBox;
        private Label currRateLabel;
        private Label label9;
        private Label currDepartmentLabel;
        private Label label7;
        private Label errMsg;
        private Button deleteButton;
    }
}
