namespace DBP_TeamProject.Forms.EmployeeManagement
{
    partial class EmployeeSearch
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
            searchGroupBox = new GroupBox();
            errorMsgLabel = new Label();
            ageTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            ㅇ = new Label();
            loadButton = new Button();
            memberdataGridView = new DataGridView();
            departmentComboBox = new ComboBox();
            departmentPanel.SuspendLayout();
            searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberdataGridView).BeginInit();
            SuspendLayout();
            // 
            // departmentPanel
            // 
            departmentPanel.Controls.Add(searchGroupBox);
            departmentPanel.Location = new Point(22, 19);
            departmentPanel.Name = "departmentPanel";
            departmentPanel.Size = new Size(747, 463);
            departmentPanel.TabIndex = 12;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(errorMsgLabel);
            searchGroupBox.Controls.Add(ageTextBox);
            searchGroupBox.Controls.Add(label2);
            searchGroupBox.Controls.Add(nameTextBox);
            searchGroupBox.Controls.Add(label1);
            searchGroupBox.Controls.Add(ㅇ);
            searchGroupBox.Controls.Add(loadButton);
            searchGroupBox.Controls.Add(memberdataGridView);
            searchGroupBox.Controls.Add(departmentComboBox);
            searchGroupBox.Location = new Point(12, 3);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(725, 327);
            searchGroupBox.TabIndex = 15;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "사원 검색";
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.Location = new Point(42, 72);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 15);
            errorMsgLabel.TabIndex = 22;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(405, 39);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(100, 23);
            ageTextBox.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 20;
            label2.Text = "나이";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(251, 38);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 43);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 18;
            label1.Text = "이름";
            // 
            // ㅇ
            // 
            ㅇ.AutoSize = true;
            ㅇ.Location = new Point(42, 42);
            ㅇ.Name = "ㅇ";
            ㅇ.Size = new Size(31, 15);
            ㅇ.TabIndex = 17;
            ㅇ.Text = "부서";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(563, 22);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(130, 55);
            loadButton.TabIndex = 15;
            loadButton.Text = "검색하기";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // memberdataGridView
            // 
            memberdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberdataGridView.Location = new Point(35, 94);
            memberdataGridView.Name = "memberdataGridView";
            memberdataGridView.RowTemplate.Height = 25;
            memberdataGridView.Size = new Size(658, 211);
            memberdataGridView.TabIndex = 14;
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "인사 부서 ", "개발 부서", "기획 부서" });
            departmentComboBox.Location = new Point(76, 38);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(121, 23);
            departmentComboBox.TabIndex = 13;
            departmentComboBox.DropDown += departmentComboBox_DropDown;
            // 
            // EmployeeSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentPanel);
            Name = "EmployeeSearch";
            Size = new Size(791, 500);
            departmentPanel.ResumeLayout(false);
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memberdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel departmentPanel;
        private ComboBox departmentComboBox;
        private GroupBox searchGroupBox;
        private Button loadButton;
        private DataGridView memberdataGridView;
        private Label ㅇ;
        private TextBox ageTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private Label errorMsgLabel;
    }
}
