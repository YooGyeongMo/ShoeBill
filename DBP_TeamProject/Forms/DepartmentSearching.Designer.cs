namespace DBP_TeamProject.Forms
{
    partial class DepartmentSearching
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
            groupBox3 = new GroupBox();
            recent_exist_department_employee_name_searching_btn = new Button();
            after_input_or_update_depart_name_showing_comboxBox_for_searching = new ComboBox();
            specific_depart_name_searching = new Button();
            searching_depart_all_result_btn = new Button();
            depature_result_show_GV = new DataGridView();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depature_result_show_GV).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(recent_exist_department_employee_name_searching_btn);
            groupBox3.Controls.Add(after_input_or_update_depart_name_showing_comboxBox_for_searching);
            groupBox3.Controls.Add(specific_depart_name_searching);
            groupBox3.Controls.Add(searching_depart_all_result_btn);
            groupBox3.Controls.Add(depature_result_show_GV);
            groupBox3.Location = new Point(16, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1198, 501);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "부서현황";
            // 
            // recent_exist_department_employee_name_searching_btn
            // 
            recent_exist_department_employee_name_searching_btn.Location = new Point(895, 38);
            recent_exist_department_employee_name_searching_btn.Name = "recent_exist_department_employee_name_searching_btn";
            recent_exist_department_employee_name_searching_btn.Size = new Size(263, 46);
            recent_exist_department_employee_name_searching_btn.TabIndex = 8;
            recent_exist_department_employee_name_searching_btn.Text = "부서별 사원이름 조회";
            recent_exist_department_employee_name_searching_btn.UseVisualStyleBackColor = true;
            recent_exist_department_employee_name_searching_btn.Click += recent_exist_department_employee_name_searching_btn_Click;
            // 
            // after_input_or_update_depart_name_showing_comboxBox_for_searching
            // 
            after_input_or_update_depart_name_showing_comboxBox_for_searching.FormattingEnabled = true;
            after_input_or_update_depart_name_showing_comboxBox_for_searching.Location = new Point(647, 44);
            after_input_or_update_depart_name_showing_comboxBox_for_searching.Name = "after_input_or_update_depart_name_showing_comboxBox_for_searching";
            after_input_or_update_depart_name_showing_comboxBox_for_searching.Size = new Size(242, 40);
            after_input_or_update_depart_name_showing_comboxBox_for_searching.TabIndex = 7;
            // 
            // specific_depart_name_searching
            // 
            specific_depart_name_searching.Location = new Point(895, 101);
            specific_depart_name_searching.Name = "specific_depart_name_searching";
            specific_depart_name_searching.Size = new Size(263, 46);
            specific_depart_name_searching.TabIndex = 6;
            specific_depart_name_searching.Text = "특정 부서 부서장 조회";
            specific_depart_name_searching.UseVisualStyleBackColor = true;
            specific_depart_name_searching.Click += specific_depart_name_searching_Click;
            // 
            // searching_depart_all_result_btn
            // 
            searching_depart_all_result_btn.Location = new Point(45, 38);
            searching_depart_all_result_btn.Name = "searching_depart_all_result_btn";
            searching_depart_all_result_btn.Size = new Size(328, 46);
            searching_depart_all_result_btn.TabIndex = 5;
            searching_depart_all_result_btn.Text = "부서별 부서장 전체 조회";
            searching_depart_all_result_btn.UseVisualStyleBackColor = true;
            searching_depart_all_result_btn.Click += searching_depart_all_result_btn_Click;
            // 
            // depature_result_show_GV
            // 
            depature_result_show_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            depature_result_show_GV.Location = new Point(25, 176);
            depature_result_show_GV.Name = "depature_result_show_GV";
            depature_result_show_GV.RowHeadersWidth = 82;
            depature_result_show_GV.RowTemplate.Height = 41;
            depature_result_show_GV.Size = new Size(1133, 263);
            depature_result_show_GV.TabIndex = 4;
            // 
            // DepartmentSearching
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Margin = new Padding(6);
            Name = "DepartmentSearching";
            Size = new Size(1654, 1067);
            Load += DepartmentSearching_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)depature_result_show_GV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button recent_exist_department_employee_name_searching_btn;
        private ComboBox after_input_or_update_depart_name_showing_comboxBox_for_searching;
        private Button specific_depart_name_searching;
        private Button searching_depart_all_result_btn;
        private DataGridView depature_result_show_GV;
    }
}
