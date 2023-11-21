namespace DBP_TeamProject.Forms
{
    partial class AttendanceManagement
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
            AttendancePanel = new Panel();
            GoHome_btn = new Button();
            GoToWork_btn = new Button();
            AttendanceOutputBox = new GroupBox();
            AttendanceTime_GRP = new GroupBox();
            AttendanceTime_GV = new DataGridView();
            GoToHomeTime_GRP = new GroupBox();
            GoToHomeTime_GV = new DataGridView();
            errorMsgLabel = new Label();
            EmployeeInputBox = new GroupBox();
            Employee_ID_inputbox = new TextBox();
            label1 = new Label();
            WorkOrHome_Screen = new Label();
            HomeOrWork_Employee_Type_Screen = new Label();
            HomeOrWork_Employee_name_Screen = new Label();
            AttendancePanel.SuspendLayout();
            AttendanceOutputBox.SuspendLayout();
            AttendanceTime_GRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceTime_GV).BeginInit();
            GoToHomeTime_GRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GoToHomeTime_GV).BeginInit();
            EmployeeInputBox.SuspendLayout();
            SuspendLayout();
            // 
            // AttendancePanel
            // 
            AttendancePanel.Controls.Add(GoHome_btn);
            AttendancePanel.Controls.Add(GoToWork_btn);
            AttendancePanel.Controls.Add(AttendanceOutputBox);
            AttendancePanel.Location = new Point(16, 0);
            AttendancePanel.Margin = new Padding(6);
            AttendancePanel.Name = "AttendancePanel";
            AttendancePanel.Size = new Size(1568, 851);
            AttendancePanel.TabIndex = 12;
            // 
            // GoHome_btn
            // 
            GoHome_btn.Location = new Point(935, 700);
            GoHome_btn.Name = "GoHome_btn";
            GoHome_btn.Size = new Size(535, 81);
            GoHome_btn.TabIndex = 2;
            GoHome_btn.Text = "퇴근";
            GoHome_btn.UseVisualStyleBackColor = true;
            GoHome_btn.Click += GoHome_btn_Click;
            // 
            // GoToWork_btn
            // 
            GoToWork_btn.Location = new Point(78, 700);
            GoToWork_btn.Margin = new Padding(6);
            GoToWork_btn.Name = "GoToWork_btn";
            GoToWork_btn.Size = new Size(556, 81);
            GoToWork_btn.TabIndex = 1;
            GoToWork_btn.Text = "출근";
            GoToWork_btn.UseVisualStyleBackColor = true;
            GoToWork_btn.Click += GoToWork_btn_Click;
            // 
            // AttendanceOutputBox
            // 
            AttendanceOutputBox.Controls.Add(AttendanceTime_GRP);
            AttendanceOutputBox.Controls.Add(GoToHomeTime_GRP);
            AttendanceOutputBox.Controls.Add(errorMsgLabel);
            AttendanceOutputBox.Controls.Add(EmployeeInputBox);
            AttendanceOutputBox.Location = new Point(78, 26);
            AttendanceOutputBox.Margin = new Padding(6);
            AttendanceOutputBox.Name = "AttendanceOutputBox";
            AttendanceOutputBox.Padding = new Padding(6);
            AttendanceOutputBox.Size = new Size(1392, 640);
            AttendanceOutputBox.TabIndex = 1;
            AttendanceOutputBox.TabStop = false;
            AttendanceOutputBox.Text = "출 퇴근 입력기";
            // 
            // AttendanceTime_GRP
            // 
            AttendanceTime_GRP.Controls.Add(AttendanceTime_GV);
            AttendanceTime_GRP.Location = new Point(41, 66);
            AttendanceTime_GRP.Margin = new Padding(6);
            AttendanceTime_GRP.Name = "AttendanceTime_GRP";
            AttendanceTime_GRP.Padding = new Padding(6);
            AttendanceTime_GRP.Size = new Size(706, 224);
            AttendanceTime_GRP.TabIndex = 4;
            AttendanceTime_GRP.TabStop = false;
            AttendanceTime_GRP.Text = "출근시간";
            // 
            // AttendanceTime_GV
            // 
            AttendanceTime_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceTime_GV.Location = new Point(0, 41);
            AttendanceTime_GV.Name = "AttendanceTime_GV";
            AttendanceTime_GV.RowHeadersWidth = 82;
            AttendanceTime_GV.RowTemplate.Height = 41;
            AttendanceTime_GV.Size = new Size(700, 161);
            AttendanceTime_GV.TabIndex = 0;
            AttendanceTime_GV.Visible = false;
            // 
            // GoToHomeTime_GRP
            // 
            GoToHomeTime_GRP.Controls.Add(GoToHomeTime_GV);
            GoToHomeTime_GRP.Location = new Point(35, 302);
            GoToHomeTime_GRP.Margin = new Padding(6);
            GoToHomeTime_GRP.Name = "GoToHomeTime_GRP";
            GoToHomeTime_GRP.Padding = new Padding(6);
            GoToHomeTime_GRP.Size = new Size(706, 224);
            GoToHomeTime_GRP.TabIndex = 5;
            GoToHomeTime_GRP.TabStop = false;
            GoToHomeTime_GRP.Text = "퇴근시간";
            // 
            // GoToHomeTime_GV
            // 
            GoToHomeTime_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GoToHomeTime_GV.Location = new Point(0, 41);
            GoToHomeTime_GV.Name = "GoToHomeTime_GV";
            GoToHomeTime_GV.RowHeadersWidth = 82;
            GoToHomeTime_GV.RowTemplate.Height = 41;
            GoToHomeTime_GV.Size = new Size(700, 161);
            GoToHomeTime_GV.TabIndex = 0;
            GoToHomeTime_GV.Visible = false;
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(41, 581);
            errorMsgLabel.Margin = new Padding(6, 0, 6, 0);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 32);
            errorMsgLabel.TabIndex = 6;
            // 
            // EmployeeInputBox
            // 
            EmployeeInputBox.Controls.Add(Employee_ID_inputbox);
            EmployeeInputBox.Controls.Add(label1);
            EmployeeInputBox.Controls.Add(WorkOrHome_Screen);
            EmployeeInputBox.Controls.Add(HomeOrWork_Employee_Type_Screen);
            EmployeeInputBox.Controls.Add(HomeOrWork_Employee_name_Screen);
            EmployeeInputBox.ForeColor = SystemColors.WindowText;
            EmployeeInputBox.Location = new Point(834, 66);
            EmployeeInputBox.Margin = new Padding(6);
            EmployeeInputBox.Name = "EmployeeInputBox";
            EmployeeInputBox.Padding = new Padding(6);
            EmployeeInputBox.Size = new Size(484, 299);
            EmployeeInputBox.TabIndex = 5;
            EmployeeInputBox.TabStop = false;
            EmployeeInputBox.Text = "사원 정보";
            // 
            // Employee_ID_inputbox
            // 
            Employee_ID_inputbox.Location = new Point(142, 185);
            Employee_ID_inputbox.Name = "Employee_ID_inputbox";
            Employee_ID_inputbox.Size = new Size(200, 39);
            Employee_ID_inputbox.TabIndex = 5;
            Employee_ID_inputbox.Click += Employee_ID_inputbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 188);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 3;
            label1.Text = "사번";
            // 
            // WorkOrHome_Screen
            // 
            WorkOrHome_Screen.AutoSize = true;
            WorkOrHome_Screen.Location = new Point(232, 50);
            WorkOrHome_Screen.Name = "WorkOrHome_Screen";
            WorkOrHome_Screen.Size = new Size(187, 32);
            WorkOrHome_Screen.TabIndex = 2;
            WorkOrHome_Screen.Text = "출근하셨습니다.";
            WorkOrHome_Screen.Visible = false;
            // 
            // HomeOrWork_Employee_Type_Screen
            // 
            HomeOrWork_Employee_Type_Screen.AutoSize = true;
            HomeOrWork_Employee_Type_Screen.Location = new Point(115, 50);
            HomeOrWork_Employee_Type_Screen.Name = "HomeOrWork_Employee_Type_Screen";
            HomeOrWork_Employee_Type_Screen.Size = new Size(62, 32);
            HomeOrWork_Employee_Type_Screen.TabIndex = 1;
            HomeOrWork_Employee_Type_Screen.Text = "사원";
            HomeOrWork_Employee_Type_Screen.Visible = false;
            // 
            // HomeOrWork_Employee_name_Screen
            // 
            HomeOrWork_Employee_name_Screen.AutoSize = true;
            HomeOrWork_Employee_name_Screen.Location = new Point(23, 50);
            HomeOrWork_Employee_name_Screen.Name = "HomeOrWork_Employee_name_Screen";
            HomeOrWork_Employee_name_Screen.Size = new Size(86, 32);
            HomeOrWork_Employee_name_Screen.TabIndex = 0;
            HomeOrWork_Employee_name_Screen.Text = "유경모";
            HomeOrWork_Employee_name_Screen.Visible = false;
            // 
            // AttendanceManagement
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AttendancePanel);
            Margin = new Padding(6);
            Name = "AttendanceManagement";
            Size = new Size(1600, 1067);
            AttendancePanel.ResumeLayout(false);
            AttendanceOutputBox.ResumeLayout(false);
            AttendanceOutputBox.PerformLayout();
            AttendanceTime_GRP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AttendanceTime_GV).EndInit();
            GoToHomeTime_GRP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GoToHomeTime_GV).EndInit();
            EmployeeInputBox.ResumeLayout(false);
            EmployeeInputBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AttendancePanel;
        private Button GoToWork_btn;
        private GroupBox AttendanceOutputBox;
        private Label errorMsgLabel;
        private GroupBox EmployeeInputBox;
        private GroupBox AttendanceTime_GRP;
        private Button GoHome_btn;
        private DataGridView AttendanceTime_GV;
        private GroupBox GoToHomeTime_GRP;
        private DataGridView GoToHomeTime_GV;
        private Label WorkOrHome_Screen;
        private Label HomeOrWork_Employee_Type_Screen;
        private Label HomeOrWork_Employee_name_Screen;
        private TextBox Employee_ID_inputbox;
        private Label label1;
    }
}
