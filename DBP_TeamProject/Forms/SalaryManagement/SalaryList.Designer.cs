namespace DBP_TeamProject.Forms.SalaryManagement
{
    partial class SalaryList
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
            salaryScreen = new DataGridView();
            loadButton = new Button();
            loadDataGroupBox = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)salaryScreen).BeginInit();
            loadDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // salaryScreen
            // 
            salaryScreen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salaryScreen.Location = new Point(20, 55);
            salaryScreen.Margin = new Padding(2);
            salaryScreen.Name = "salaryScreen";
            salaryScreen.RowHeadersWidth = 51;
            salaryScreen.RowTemplate.Height = 29;
            salaryScreen.Size = new Size(720, 231);
            salaryScreen.TabIndex = 0;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(624, 298);
            loadButton.Margin = new Padding(2);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(116, 39);
            loadButton.TabIndex = 1;
            loadButton.Text = "조회하기";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // loadDataGroupBox
            // 
            loadDataGroupBox.Controls.Add(dateTimePicker1);
            loadDataGroupBox.Controls.Add(salaryScreen);
            loadDataGroupBox.Controls.Add(loadButton);
            loadDataGroupBox.Location = new Point(13, 24);
            loadDataGroupBox.Margin = new Padding(2);
            loadDataGroupBox.Name = "loadDataGroupBox";
            loadDataGroupBox.Padding = new Padding(2);
            loadDataGroupBox.Size = new Size(757, 353);
            loadDataGroupBox.TabIndex = 2;
            loadDataGroupBox.TabStop = false;
            loadDataGroupBox.Text = "1개월 급여 내역";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(540, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // SalaryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loadDataGroupBox);
            Name = "SalaryList";
            Size = new Size(786, 481);
            ((System.ComponentModel.ISupportInitialize)salaryScreen).EndInit();
            loadDataGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView salaryScreen;
        private Button loadButton;
        private GroupBox loadDataGroupBox;
        private DateTimePicker dateTimePicker1;
    }
}
