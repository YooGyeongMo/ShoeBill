namespace DBP_TeamProject.Forms
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
            salaryDataGridView = new DataGridView();
            salaryLoadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)salaryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // salaryDataGridView
            // 
            salaryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salaryDataGridView.Location = new Point(23, 18);
            salaryDataGridView.Name = "salaryDataGridView";
            salaryDataGridView.RowTemplate.Height = 25;
            salaryDataGridView.Size = new Size(574, 270);
            salaryDataGridView.TabIndex = 1;
            // 
            // salaryLoadButton
            // 
            salaryLoadButton.Location = new Point(606, 298);
            salaryLoadButton.Name = "salaryLoadButton";
            salaryLoadButton.Size = new Size(107, 48);
            salaryLoadButton.TabIndex = 2;
            salaryLoadButton.Text = "급여 조회하기";
            salaryLoadButton.UseVisualStyleBackColor = true;
            salaryLoadButton.Click += salaryLoadButton_Click;
            // 
            // SalaryStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(salaryLoadButton);
            Controls.Add(salaryDataGridView);
            Name = "SalaryStatement";
            Size = new Size(728, 362);
            ((System.ComponentModel.ISupportInitialize)salaryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView salaryDataGridView;
        private Button salaryLoadButton;
    }
}
