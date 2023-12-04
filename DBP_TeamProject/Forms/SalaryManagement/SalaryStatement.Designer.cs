namespace DBP_TeamProject.Forms.SalaryManagement
{
    partial class SalaryStatement
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
            salarySaveButton = new Button();
            NightTimeLoadButton = new Button();
            AttendanceTime_GV = new DataGridView();
            calculateWorkTimeButton = new Button();
            label1 = new Label();
            idTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            overTimeWork = new Label();
            nightWork = new Label();
            holidayWork = new Label();
            additWorkGroupBox = new GroupBox();
            HolidayTimeLoadButton = new Button();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            workTimeRegistPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)AttendanceTime_GV).BeginInit();
            additWorkGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            workTimeRegistPanel.SuspendLayout();
            SuspendLayout();
            // 
            // salarySaveButton
            // 
            salarySaveButton.Location = new Point(707, 377);
            salarySaveButton.Margin = new Padding(4);
            salarySaveButton.Name = "salarySaveButton";
            salarySaveButton.Size = new Size(183, 79);
            salarySaveButton.TabIndex = 2;
            salarySaveButton.Text = "근로 시간 등록하기";
            salarySaveButton.UseVisualStyleBackColor = true;
            salarySaveButton.Click += salarySaveButton_Click;
            // 
            // NightTimeLoadButton
            // 
            NightTimeLoadButton.Location = new Point(332, 428);
            NightTimeLoadButton.Margin = new Padding(4);
            NightTimeLoadButton.Name = "NightTimeLoadButton";
            NightTimeLoadButton.Size = new Size(129, 57);
            NightTimeLoadButton.TabIndex = 3;
            NightTimeLoadButton.Text = "야간 근로 시간 조회";
            NightTimeLoadButton.UseVisualStyleBackColor = true;
            NightTimeLoadButton.Click += additWorkTimeLoadButton_Click;
            // 
            // AttendanceTime_GV
            // 
            AttendanceTime_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceTime_GV.Location = new Point(28, 151);
            AttendanceTime_GV.Margin = new Padding(4);
            AttendanceTime_GV.Name = "AttendanceTime_GV";
            AttendanceTime_GV.RowHeadersWidth = 51;
            AttendanceTime_GV.RowTemplate.Height = 25;
            AttendanceTime_GV.Size = new Size(568, 269);
            AttendanceTime_GV.TabIndex = 6;
            // 
            // calculateWorkTimeButton
            // 
            calculateWorkTimeButton.Location = new Point(131, 196);
            calculateWorkTimeButton.Margin = new Padding(4);
            calculateWorkTimeButton.Name = "calculateWorkTimeButton";
            calculateWorkTimeButton.Size = new Size(176, 36);
            calculateWorkTimeButton.TabIndex = 7;
            calculateWorkTimeButton.Text = "추가 근로 시간 계산";
            calculateWorkTimeButton.UseVisualStyleBackColor = true;
            calculateWorkTimeButton.Click += calculateWorkTimeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 8;
            label1.Text = "사번 입력";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(109, 39);
            idTextBox.Margin = new Padding(4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(127, 27);
            idTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "연장근로 시간";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 11;
            label3.Text = "야간근로 시간";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 159);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 12;
            label4.Text = "휴일근로 시간";
            // 
            // overTimeWork
            // 
            overTimeWork.AutoSize = true;
            overTimeWork.Location = new Point(159, 52);
            overTimeWork.Margin = new Padding(4, 0, 4, 0);
            overTimeWork.Name = "overTimeWork";
            overTimeWork.Size = new Size(0, 20);
            overTimeWork.TabIndex = 13;
            // 
            // nightWork
            // 
            nightWork.AutoSize = true;
            nightWork.Location = new Point(159, 109);
            nightWork.Margin = new Padding(4, 0, 4, 0);
            nightWork.Name = "nightWork";
            nightWork.Size = new Size(0, 20);
            nightWork.TabIndex = 14;
            // 
            // holidayWork
            // 
            holidayWork.AutoSize = true;
            holidayWork.Location = new Point(159, 159);
            holidayWork.Margin = new Padding(4, 0, 4, 0);
            holidayWork.Name = "holidayWork";
            holidayWork.Size = new Size(0, 20);
            holidayWork.TabIndex = 15;
            // 
            // additWorkGroupBox
            // 
            additWorkGroupBox.Controls.Add(label2);
            additWorkGroupBox.Controls.Add(holidayWork);
            additWorkGroupBox.Controls.Add(calculateWorkTimeButton);
            additWorkGroupBox.Controls.Add(nightWork);
            additWorkGroupBox.Controls.Add(label3);
            additWorkGroupBox.Controls.Add(overTimeWork);
            additWorkGroupBox.Controls.Add(label4);
            additWorkGroupBox.Location = new Point(636, 99);
            additWorkGroupBox.Name = "additWorkGroupBox";
            additWorkGroupBox.Size = new Size(325, 253);
            additWorkGroupBox.TabIndex = 16;
            additWorkGroupBox.TabStop = false;
            additWorkGroupBox.Text = "근로 시간 계산";
            // 
            // HolidayTimeLoadButton
            // 
            HolidayTimeLoadButton.Location = new Point(468, 428);
            HolidayTimeLoadButton.Margin = new Padding(4);
            HolidayTimeLoadButton.Name = "HolidayTimeLoadButton";
            HolidayTimeLoadButton.Size = new Size(129, 57);
            HolidayTimeLoadButton.TabIndex = 17;
            HolidayTimeLoadButton.Text = "휴일 근로 시간 조회";
            HolidayTimeLoadButton.UseVisualStyleBackColor = true;
            HolidayTimeLoadButton.Click += HolidayTimeLoadButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(274, 25);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(323, 104);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "월간 조회";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(32, 44);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // workTimeRegistPanel
            // 
            workTimeRegistPanel.Controls.Add(label1);
            workTimeRegistPanel.Controls.Add(groupBox3);
            workTimeRegistPanel.Controls.Add(idTextBox);
            workTimeRegistPanel.Controls.Add(salarySaveButton);
            workTimeRegistPanel.Controls.Add(AttendanceTime_GV);
            workTimeRegistPanel.Controls.Add(HolidayTimeLoadButton);
            workTimeRegistPanel.Controls.Add(additWorkGroupBox);
            workTimeRegistPanel.Controls.Add(NightTimeLoadButton);
            workTimeRegistPanel.Location = new Point(17, 4);
            workTimeRegistPanel.Margin = new Padding(4);
            workTimeRegistPanel.Name = "workTimeRegistPanel";
            workTimeRegistPanel.Size = new Size(996, 523);
            workTimeRegistPanel.TabIndex = 20;
            // 
            // SalaryStatement
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(workTimeRegistPanel);
            Margin = new Padding(4);
            Name = "SalaryStatement";
            Size = new Size(1090, 643);
            ((System.ComponentModel.ISupportInitialize)AttendanceTime_GV).EndInit();
            additWorkGroupBox.ResumeLayout(false);
            additWorkGroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            workTimeRegistPanel.ResumeLayout(false);
            workTimeRegistPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button salarySaveButton;
        private Button NightTimeLoadButton;
        private DataGridView AttendanceTime_GV;
        private Button calculateWorkTimeButton;
        private Label label1;
        private TextBox idTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label overTimeWork;
        private Label nightWork;
        private Label holidayWork;
        private GroupBox additWorkGroupBox;
        private Button HolidayTimeLoadButton;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private Panel workTimeRegistPanel;
    }
}
