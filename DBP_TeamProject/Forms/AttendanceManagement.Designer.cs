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
            AttendanceOutputBox = new GroupBox();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            nightAdditionalWorkLoadbutton = new Button();
            weekendAdditionalWorkLoadbutton = new Button();
            loadButton = new Button();
            AttendanceTime_GRP = new GroupBox();
            AttendanceTime_GV = new DataGridView();
            EmployeeInputBox = new GroupBox();
            GoHome_btn = new Button();
            GoToWork_btn = new Button();
            Employee_ID_inputbox = new TextBox();
            label1 = new Label();
            WorkOrHome_Screen = new Label();
            HomeOrWork_Employee_Type_Screen = new Label();
            HomeOrWork_Employee_name_Screen = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker100 = new DateTimePicker();
            eXGoHome_btn = new Button();
            eXGoToWork_btn = new Button();
            AttendancePanel.SuspendLayout();
            AttendanceOutputBox.SuspendLayout();
            groupBox3.SuspendLayout();
            AttendanceTime_GRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceTime_GV).BeginInit();
            EmployeeInputBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AttendancePanel
            // 
            AttendancePanel.Controls.Add(AttendanceOutputBox);
            AttendancePanel.Location = new Point(8, 0);
            AttendancePanel.Name = "AttendancePanel";
            AttendancePanel.Size = new Size(788, 394);
            AttendancePanel.TabIndex = 12;
            // 
            // AttendanceOutputBox
            // 
            AttendanceOutputBox.Controls.Add(groupBox3);
            AttendanceOutputBox.Controls.Add(nightAdditionalWorkLoadbutton);
            AttendanceOutputBox.Controls.Add(weekendAdditionalWorkLoadbutton);
            AttendanceOutputBox.Controls.Add(loadButton);
            AttendanceOutputBox.Controls.Add(AttendanceTime_GRP);
            AttendanceOutputBox.Controls.Add(EmployeeInputBox);
            AttendanceOutputBox.Location = new Point(3, 12);
            AttendanceOutputBox.Name = "AttendanceOutputBox";
            AttendanceOutputBox.Size = new Size(765, 367);
            AttendanceOutputBox.TabIndex = 1;
            AttendanceOutputBox.TabStop = false;
            AttendanceOutputBox.Text = "출 퇴근 입력기";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(20, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 78);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "월간 조회";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(25, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // nightAdditionalWorkLoadbutton
            // 
            nightAdditionalWorkLoadbutton.Location = new Point(383, 311);
            nightAdditionalWorkLoadbutton.Name = "nightAdditionalWorkLoadbutton";
            nightAdditionalWorkLoadbutton.Size = new Size(117, 43);
            nightAdditionalWorkLoadbutton.TabIndex = 13;
            nightAdditionalWorkLoadbutton.Text = "야간 근로 조회";
            nightAdditionalWorkLoadbutton.UseVisualStyleBackColor = true;
            nightAdditionalWorkLoadbutton.Click += nightAdditionalWorkLoadbutton_Click;
            // 
            // weekendAdditionalWorkLoadbutton
            // 
            weekendAdditionalWorkLoadbutton.Location = new Point(506, 311);
            weekendAdditionalWorkLoadbutton.Name = "weekendAdditionalWorkLoadbutton";
            weekendAdditionalWorkLoadbutton.Size = new Size(117, 43);
            weekendAdditionalWorkLoadbutton.TabIndex = 12;
            weekendAdditionalWorkLoadbutton.Text = "휴일 근로 조회";
            weekendAdditionalWorkLoadbutton.UseVisualStyleBackColor = true;
            weekendAdditionalWorkLoadbutton.Click += additionalWorkLoadbutton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(629, 311);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(117, 43);
            loadButton.TabIndex = 7;
            loadButton.Text = "일반 조회";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // AttendanceTime_GRP
            // 
            AttendanceTime_GRP.Controls.Add(AttendanceTime_GV);
            AttendanceTime_GRP.Location = new Point(290, 29);
            AttendanceTime_GRP.Name = "AttendanceTime_GRP";
            AttendanceTime_GRP.Size = new Size(456, 274);
            AttendanceTime_GRP.TabIndex = 4;
            AttendanceTime_GRP.TabStop = false;
            AttendanceTime_GRP.Text = "출/퇴근시간";
            // 
            // AttendanceTime_GV
            // 
            AttendanceTime_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceTime_GV.Location = new Point(20, 33);
            AttendanceTime_GV.Name = "AttendanceTime_GV";
            AttendanceTime_GV.RowHeadersWidth = 82;
            AttendanceTime_GV.RowTemplate.Height = 25;
            AttendanceTime_GV.Size = new Size(420, 225);
            AttendanceTime_GV.TabIndex = 0;
            // 
            // EmployeeInputBox
            // 
            EmployeeInputBox.Controls.Add(GoHome_btn);
            EmployeeInputBox.Controls.Add(GoToWork_btn);
            EmployeeInputBox.Controls.Add(Employee_ID_inputbox);
            EmployeeInputBox.Controls.Add(label1);
            EmployeeInputBox.Controls.Add(WorkOrHome_Screen);
            EmployeeInputBox.Controls.Add(HomeOrWork_Employee_Type_Screen);
            EmployeeInputBox.Controls.Add(HomeOrWork_Employee_name_Screen);
            EmployeeInputBox.ForeColor = SystemColors.WindowText;
            EmployeeInputBox.Location = new Point(20, 29);
            EmployeeInputBox.Name = "EmployeeInputBox";
            EmployeeInputBox.Size = new Size(251, 174);
            EmployeeInputBox.TabIndex = 5;
            EmployeeInputBox.TabStop = false;
            EmployeeInputBox.Text = "사원 정보";
            // 
            // GoHome_btn
            // 
            GoHome_btn.Location = new Point(126, 120);
            GoHome_btn.Margin = new Padding(2);
            GoHome_btn.Name = "GoHome_btn";
            GoHome_btn.Size = new Size(111, 43);
            GoHome_btn.TabIndex = 2;
            GoHome_btn.Text = "퇴근";
            GoHome_btn.UseVisualStyleBackColor = true;
            GoHome_btn.Click += GoHome_btn_Click;
            // 
            // GoToWork_btn
            // 
            GoToWork_btn.Location = new Point(10, 120);
            GoToWork_btn.Name = "GoToWork_btn";
            GoToWork_btn.Size = new Size(111, 43);
            GoToWork_btn.TabIndex = 1;
            GoToWork_btn.Text = "출근";
            GoToWork_btn.UseVisualStyleBackColor = true;
            GoToWork_btn.Click += GoToWork_btn_Click;
            // 
            // Employee_ID_inputbox
            // 
            Employee_ID_inputbox.Location = new Point(103, 85);
            Employee_ID_inputbox.Margin = new Padding(2);
            Employee_ID_inputbox.Name = "Employee_ID_inputbox";
            Employee_ID_inputbox.Size = new Size(102, 23);
            Employee_ID_inputbox.TabIndex = 5;
            Employee_ID_inputbox.Click += Employee_ID_inputbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "사번 입력";
            // 
            // WorkOrHome_Screen
            // 
            WorkOrHome_Screen.AutoSize = true;
            WorkOrHome_Screen.Location = new Point(136, 43);
            WorkOrHome_Screen.Margin = new Padding(2, 0, 2, 0);
            WorkOrHome_Screen.Name = "WorkOrHome_Screen";
            WorkOrHome_Screen.Size = new Size(110, 15);
            WorkOrHome_Screen.TabIndex = 2;
            WorkOrHome_Screen.Text = "님 출근하셨습니다.";
            WorkOrHome_Screen.Visible = false;
            // 
            // HomeOrWork_Employee_Type_Screen
            // 
            HomeOrWork_Employee_Type_Screen.AutoSize = true;
            HomeOrWork_Employee_Type_Screen.Location = new Point(78, 43);
            HomeOrWork_Employee_Type_Screen.Margin = new Padding(2, 0, 2, 0);
            HomeOrWork_Employee_Type_Screen.Name = "HomeOrWork_Employee_Type_Screen";
            HomeOrWork_Employee_Type_Screen.Size = new Size(31, 15);
            HomeOrWork_Employee_Type_Screen.TabIndex = 1;
            HomeOrWork_Employee_Type_Screen.Text = "사원";
            HomeOrWork_Employee_Type_Screen.Visible = false;
            // 
            // HomeOrWork_Employee_name_Screen
            // 
            HomeOrWork_Employee_name_Screen.AutoSize = true;
            HomeOrWork_Employee_name_Screen.Location = new Point(32, 43);
            HomeOrWork_Employee_name_Screen.Margin = new Padding(2, 0, 2, 0);
            HomeOrWork_Employee_name_Screen.Name = "HomeOrWork_Employee_name_Screen";
            HomeOrWork_Employee_name_Screen.Size = new Size(43, 15);
            HomeOrWork_Employee_name_Screen.TabIndex = 0;
            HomeOrWork_Employee_name_Screen.Text = "유경모";
            HomeOrWork_Employee_name_Screen.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker100);
            groupBox1.Controls.Add(eXGoHome_btn);
            groupBox1.Controls.Add(eXGoToWork_btn);
            groupBox1.Location = new Point(31, 428);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 129);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "샘플 데이터 생성";
            // 
            // dateTimePicker100
            // 
            dateTimePicker100.CustomFormat = "";
            dateTimePicker100.Location = new Point(25, 29);
            dateTimePicker100.Name = "dateTimePicker100";
            dateTimePicker100.Size = new Size(200, 23);
            dateTimePicker100.TabIndex = 8;
            // 
            // eXGoHome_btn
            // 
            eXGoHome_btn.Location = new Point(126, 71);
            eXGoHome_btn.Margin = new Padding(2);
            eXGoHome_btn.Name = "eXGoHome_btn";
            eXGoHome_btn.Size = new Size(111, 43);
            eXGoHome_btn.TabIndex = 6;
            eXGoHome_btn.Text = "퇴근";
            eXGoHome_btn.UseVisualStyleBackColor = true;
            eXGoHome_btn.Click += eXGoHome_btn_Click;
            // 
            // eXGoToWork_btn
            // 
            eXGoToWork_btn.Location = new Point(10, 71);
            eXGoToWork_btn.Name = "eXGoToWork_btn";
            eXGoToWork_btn.Size = new Size(111, 43);
            eXGoToWork_btn.TabIndex = 6;
            eXGoToWork_btn.Text = "출근";
            eXGoToWork_btn.UseVisualStyleBackColor = true;
            eXGoToWork_btn.Click += eXGoToWork_btn_Click;
            // 
            // AttendanceManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(AttendancePanel);
            Name = "AttendanceManagement";
            Size = new Size(831, 640);
            AttendancePanel.ResumeLayout(false);
            AttendanceOutputBox.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            AttendanceTime_GRP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AttendanceTime_GV).EndInit();
            EmployeeInputBox.ResumeLayout(false);
            EmployeeInputBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel AttendancePanel;
        private Button GoToWork_btn;
        private GroupBox AttendanceOutputBox;
        private GroupBox EmployeeInputBox;
        private GroupBox AttendanceTime_GRP;
        private Button GoHome_btn;
        private GroupBox GoToHomeTime_GRP;
        private DataGridView GoToHomeTime_GV;
        private Label WorkOrHome_Screen;
        private Label HomeOrWork_Employee_Type_Screen;
        private Label HomeOrWork_Employee_name_Screen;
        private TextBox Employee_ID_inputbox;
        private Label label1;
        private Button loadButton;
        private DataGridView AttendanceTime_GV;
        private DateTimePicker dateTimePicker100;
        private Button eXGoHome_btn;
        private Button eXGoToWork_btn;
        private GroupBox groupBox1;
        private Button weekendAdditionalWorkLoadbutton;
        private Button nightAdditionalWorkLoadbutton;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
    }
}
