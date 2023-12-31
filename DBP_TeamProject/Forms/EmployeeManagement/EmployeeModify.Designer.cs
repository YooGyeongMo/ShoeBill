﻿namespace DBP_TeamProject.Forms.EmployeeManagement
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
            employeeManagePanel = new Panel();
            modGroupBox = new GroupBox();
            deleteButton = new Button();
            errMsg = new Label();
            currRateLabel = new Label();
            label9 = new Label();
            currDepartmentLabel = new Label();
            label7 = new Label();
            idLabel = new Label();
            label2 = new Label();
            modifyButton = new Button();
            label4 = new Label();
            label5 = new Label();
            departmentComboBox = new ComboBox();
            errorMsgLabel = new Label();
            idTextBox = new TextBox();
            label1 = new Label();
            loadButton = new Button();
            memberdataGridView = new DataGridView();
            employeeManagePanel.SuspendLayout();
            modGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberdataGridView).BeginInit();
            SuspendLayout();
            // 
            // employeeManagePanel
            // 
            employeeManagePanel.Controls.Add(modGroupBox);
            employeeManagePanel.Location = new Point(22, 21);
            employeeManagePanel.Name = "employeeManagePanel";
            employeeManagePanel.Size = new Size(747, 463);
            employeeManagePanel.TabIndex = 13;
            // 
            // modGroupBox
            // 
            modGroupBox.Controls.Add(deleteButton);
            modGroupBox.Controls.Add(errMsg);
            modGroupBox.Controls.Add(currRateLabel);
            modGroupBox.Controls.Add(label9);
            modGroupBox.Controls.Add(currDepartmentLabel);
            modGroupBox.Controls.Add(label7);
            modGroupBox.Controls.Add(idLabel);
            modGroupBox.Controls.Add(label2);
            modGroupBox.Controls.Add(modifyButton);
            modGroupBox.Controls.Add(label4);
            modGroupBox.Controls.Add(label5);
            modGroupBox.Controls.Add(departmentComboBox);
            modGroupBox.Controls.Add(errorMsgLabel);
            modGroupBox.Controls.Add(idTextBox);
            modGroupBox.Controls.Add(label1);
            modGroupBox.Controls.Add(loadButton);
            modGroupBox.Controls.Add(memberdataGridView);
            modGroupBox.Location = new Point(39, 3);
            modGroupBox.Name = "modGroupBox";
            modGroupBox.Size = new Size(676, 337);
            modGroupBox.TabIndex = 15;
            modGroupBox.TabStop = false;
            modGroupBox.Text = "사원 수정/삭제";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(578, 16);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(92, 38);
            deleteButton.TabIndex = 38;
            deleteButton.Text = "삭제하기";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // errMsg
            // 
            errMsg.AutoSize = true;
            errMsg.Location = new Point(204, 305);
            errMsg.Name = "errMsg";
            errMsg.Size = new Size(0, 15);
            errMsg.TabIndex = 37;
            // 
            // currRateLabel
            // 
            currRateLabel.AutoSize = true;
            currRateLabel.ForeColor = SystemColors.HotTrack;
            currRateLabel.Location = new Point(111, 303);
            currRateLabel.Name = "currRateLabel";
            currRateLabel.Size = new Size(0, 15);
            currRateLabel.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 303);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 35;
            label9.Text = "현재 직급";
            // 
            // currDepartmentLabel
            // 
            currDepartmentLabel.AutoSize = true;
            currDepartmentLabel.ForeColor = SystemColors.HotTrack;
            currDepartmentLabel.Location = new Point(111, 276);
            currDepartmentLabel.Name = "currDepartmentLabel";
            currDepartmentLabel.Size = new Size(0, 15);
            currDepartmentLabel.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 276);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 33;
            label7.Text = "현재 부서";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = SystemColors.HotTrack;
            idLabel.Location = new Point(111, 250);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 15);
            idLabel.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 30;
            label2.Text = "수정/삭제할 사원을 선택하세요.";
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(568, 287);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(92, 38);
            modifyButton.TabIndex = 29;
            modifyButton.Text = "수정하기";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 250);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 25;
            label4.Text = "사원 아이디";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 251);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 24;
            label5.Text = "수정할 부서";
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "인사 부서 ", "개발 부서 ", "기획 부서" });
            departmentComboBox.Location = new Point(396, 247);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(102, 23);
            departmentComboBox.TabIndex = 23;
            departmentComboBox.DropDown += departmentComboBox_DropDown;
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(98, 70);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 15);
            errorMsgLabel.TabIndex = 22;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(98, 35);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 18;
            label1.Text = "사원 이름";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(222, 36);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(117, 23);
            loadButton.TabIndex = 15;
            loadButton.Text = "수정할 사원 검색";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // memberdataGridView
            // 
            memberdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberdataGridView.Location = new Point(39, 123);
            memberdataGridView.Name = "memberdataGridView";
            memberdataGridView.RowHeadersWidth = 51;
            memberdataGridView.RowTemplate.Height = 25;
            memberdataGridView.Size = new Size(459, 100);
            memberdataGridView.TabIndex = 14;
            memberdataGridView.CellClick += memberdataGridView_CellClick;
            // 
            // EmployeeModDel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(employeeManagePanel);
            Name = "EmployeeModDel";
            Size = new Size(791, 504);
            employeeManagePanel.ResumeLayout(false);
            modGroupBox.ResumeLayout(false);
            modGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memberdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel employeeManagePanel;
        private GroupBox modGroupBox;
        private Label errorMsgLabel;
        private TextBox idTextBox;
        private Label label1;
        private Button loadButton;
        private DataGridView memberdataGridView;
        private Button modifyButton;
        private Label label4;
        private Label label5;
        private ComboBox departmentComboBox;
        private Label label2;
        private Label idLabel;
        private Label currRateLabel;
        private Label label9;
        private Label currDepartmentLabel;
        private Label label7;
        private Label errMsg;
        private Button deleteButton;
    }
}
