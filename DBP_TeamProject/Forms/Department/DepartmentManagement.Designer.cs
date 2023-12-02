namespace DBP_TeamProject.Forms
{
    partial class DepartmentManagement
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
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            label7 = new Label();
            depatment_name_update_btn = new Button();
            recent_department_list_combobox = new ComboBox();
            label6 = new Label();
            for_update_department_name_input_textbox = new TextBox();
            groupBox2 = new GroupBox();
            delete_depatment_name_btn = new Button();
            label3 = new Label();
            delete_depatment_name_input_textbox = new TextBox();
            부서등록 = new GroupBox();
            depatment_name_insert_btn = new Button();
            label1 = new Label();
            department_name_input_textbox = new TextBox();
            groupBox4 = new GroupBox();
            for_department_leader_searching_result_to_combobox_btn = new Button();
            recent_department_name_list_for_leader_searching_combobox = new ComboBox();
            for_department_leader_delete_btn = new Button();
            label4 = new Label();
            for_depatment_leader_input_employeeName_textBox = new TextBox();
            for_department_leader_insert_and_update_btn = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            부서등록.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(부서등록);
            groupBox1.Location = new Point(44, 44);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(443, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "부서관리";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(depatment_name_update_btn);
            groupBox5.Controls.Add(recent_department_list_combobox);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(for_update_department_name_input_textbox);
            groupBox5.Location = new Point(224, 45);
            groupBox5.Margin = new Padding(2, 1, 2, 1);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2, 1, 2, 1);
            groupBox5.Size = new Size(201, 165);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "부서명 수정";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 39);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 3;
            label7.Text = "부서리스트";
            // 
            // depatment_name_update_btn
            // 
            depatment_name_update_btn.Location = new Point(108, 123);
            depatment_name_update_btn.Margin = new Padding(2, 1, 2, 1);
            depatment_name_update_btn.Name = "depatment_name_update_btn";
            depatment_name_update_btn.Size = new Size(75, 22);
            depatment_name_update_btn.TabIndex = 1;
            depatment_name_update_btn.Text = "수정";
            depatment_name_update_btn.UseVisualStyleBackColor = true;
            depatment_name_update_btn.Click += depatment_name_update_btn_Click;
            // 
            // recent_department_list_combobox
            // 
            recent_department_list_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            recent_department_list_combobox.FormattingEnabled = true;
            recent_department_list_combobox.Location = new Point(81, 35);
            recent_department_list_combobox.Margin = new Padding(2, 1, 2, 1);
            recent_department_list_combobox.Name = "recent_department_list_combobox";
            recent_department_list_combobox.Size = new Size(102, 23);
            recent_department_list_combobox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 83);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "부서명";
            // 
            // for_update_department_name_input_textbox
            // 
            for_update_department_name_input_textbox.Location = new Point(81, 78);
            for_update_department_name_input_textbox.Margin = new Padding(2, 1, 2, 1);
            for_update_department_name_input_textbox.Name = "for_update_department_name_input_textbox";
            for_update_department_name_input_textbox.Size = new Size(102, 23);
            for_update_department_name_input_textbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(delete_depatment_name_btn);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(delete_depatment_name_input_textbox);
            groupBox2.Location = new Point(25, 130);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(183, 96);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "부서명 삭제";
            // 
            // delete_depatment_name_btn
            // 
            delete_depatment_name_btn.Location = new Point(88, 58);
            delete_depatment_name_btn.Margin = new Padding(2, 1, 2, 1);
            delete_depatment_name_btn.Name = "delete_depatment_name_btn";
            delete_depatment_name_btn.Size = new Size(75, 22);
            delete_depatment_name_btn.TabIndex = 1;
            delete_depatment_name_btn.Text = "삭제";
            delete_depatment_name_btn.UseVisualStyleBackColor = true;
            delete_depatment_name_btn.Click += delete_depatment_name_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "부서명";
            // 
            // delete_depatment_name_input_textbox
            // 
            delete_depatment_name_input_textbox.Location = new Point(61, 20);
            delete_depatment_name_input_textbox.Margin = new Padding(2, 1, 2, 1);
            delete_depatment_name_input_textbox.Name = "delete_depatment_name_input_textbox";
            delete_depatment_name_input_textbox.Size = new Size(102, 23);
            delete_depatment_name_input_textbox.TabIndex = 0;
            // 
            // 부서등록
            // 
            부서등록.Controls.Add(depatment_name_insert_btn);
            부서등록.Controls.Add(label1);
            부서등록.Controls.Add(department_name_input_textbox);
            부서등록.Location = new Point(25, 23);
            부서등록.Margin = new Padding(2, 1, 2, 1);
            부서등록.Name = "부서등록";
            부서등록.Padding = new Padding(2, 1, 2, 1);
            부서등록.Size = new Size(183, 96);
            부서등록.TabIndex = 0;
            부서등록.TabStop = false;
            부서등록.Text = "부서등록";
            // 
            // depatment_name_insert_btn
            // 
            depatment_name_insert_btn.Location = new Point(88, 64);
            depatment_name_insert_btn.Margin = new Padding(2, 1, 2, 1);
            depatment_name_insert_btn.Name = "depatment_name_insert_btn";
            depatment_name_insert_btn.Size = new Size(75, 22);
            depatment_name_insert_btn.TabIndex = 1;
            depatment_name_insert_btn.Text = "등록";
            depatment_name_insert_btn.UseVisualStyleBackColor = true;
            depatment_name_insert_btn.Click += depatment_name_insert_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "부서명";
            // 
            // department_name_input_textbox
            // 
            department_name_input_textbox.Location = new Point(61, 30);
            department_name_input_textbox.Margin = new Padding(2, 1, 2, 1);
            department_name_input_textbox.Name = "department_name_input_textbox";
            department_name_input_textbox.Size = new Size(102, 23);
            department_name_input_textbox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(for_department_leader_searching_result_to_combobox_btn);
            groupBox4.Controls.Add(recent_department_name_list_for_leader_searching_combobox);
            groupBox4.Controls.Add(for_department_leader_delete_btn);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(for_depatment_leader_input_employeeName_textBox);
            groupBox4.Controls.Add(for_department_leader_insert_and_update_btn);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(506, 84);
            groupBox4.Margin = new Padding(2, 1, 2, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 1, 2, 1);
            groupBox4.Size = new Size(244, 187);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "부서장 권한 관리";
            // 
            // for_department_leader_searching_result_to_combobox_btn
            // 
            for_department_leader_searching_result_to_combobox_btn.Location = new Point(5, 117);
            for_department_leader_searching_result_to_combobox_btn.Margin = new Padding(2, 1, 2, 1);
            for_department_leader_searching_result_to_combobox_btn.Name = "for_department_leader_searching_result_to_combobox_btn";
            for_department_leader_searching_result_to_combobox_btn.Size = new Size(75, 22);
            for_department_leader_searching_result_to_combobox_btn.TabIndex = 10;
            for_department_leader_searching_result_to_combobox_btn.Text = "조회";
            for_department_leader_searching_result_to_combobox_btn.UseVisualStyleBackColor = true;
            for_department_leader_searching_result_to_combobox_btn.Click += for_department_leader_searching_result_to_combobox_btn_Click;
            // 
            // recent_department_name_list_for_leader_searching_combobox
            // 
            recent_department_name_list_for_leader_searching_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            recent_department_name_list_for_leader_searching_combobox.FormattingEnabled = true;
            recent_department_name_list_for_leader_searching_combobox.Location = new Point(89, 40);
            recent_department_name_list_for_leader_searching_combobox.Margin = new Padding(2, 1, 2, 1);
            recent_department_name_list_for_leader_searching_combobox.Name = "recent_department_name_list_for_leader_searching_combobox";
            recent_department_name_list_for_leader_searching_combobox.Size = new Size(102, 23);
            recent_department_name_list_for_leader_searching_combobox.TabIndex = 9;
            // 
            // for_department_leader_delete_btn
            // 
            for_department_leader_delete_btn.Location = new Point(163, 117);
            for_department_leader_delete_btn.Margin = new Padding(2, 1, 2, 1);
            for_department_leader_delete_btn.Name = "for_department_leader_delete_btn";
            for_department_leader_delete_btn.Size = new Size(75, 22);
            for_department_leader_delete_btn.TabIndex = 4;
            for_department_leader_delete_btn.Text = "직급 해제";
            for_department_leader_delete_btn.UseVisualStyleBackColor = true;
            for_department_leader_delete_btn.Click += for_department_leader_delete_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 81);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "부서장 이름";
            // 
            // for_depatment_leader_input_employeeName_textBox
            // 
            for_depatment_leader_input_employeeName_textBox.Location = new Point(89, 76);
            for_depatment_leader_input_employeeName_textBox.Margin = new Padding(2, 1, 2, 1);
            for_depatment_leader_input_employeeName_textBox.Name = "for_depatment_leader_input_employeeName_textBox";
            for_depatment_leader_input_employeeName_textBox.Size = new Size(102, 23);
            for_depatment_leader_input_employeeName_textBox.TabIndex = 2;
            // 
            // for_department_leader_insert_and_update_btn
            // 
            for_department_leader_insert_and_update_btn.Location = new Point(84, 117);
            for_department_leader_insert_and_update_btn.Margin = new Padding(2, 1, 2, 1);
            for_department_leader_insert_and_update_btn.Name = "for_department_leader_insert_and_update_btn";
            for_department_leader_insert_and_update_btn.Size = new Size(75, 22);
            for_department_leader_insert_and_update_btn.TabIndex = 1;
            for_department_leader_insert_and_update_btn.Text = "등록";
            for_department_leader_insert_and_update_btn.UseVisualStyleBackColor = true;
            for_department_leader_insert_and_update_btn.Click += for_department_leader_insert_and_update_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "부서명";
            // 
            // DepartmentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DepartmentManagement";
            Size = new Size(827, 500);
            Load += DepartmentManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            부서등록.ResumeLayout(false);
            부서등록.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox 부서등록;
        private Label label1;
        private TextBox department_name_input_textbox;
        private GroupBox groupBox2;
        private Button delete_depatment_name_btn;
        private Label label3;
        private TextBox delete_depatment_name_input_textbox;
        private Button depatment_name_insert_btn;
        private GroupBox groupBox4;
        private Button for_department_leader_delete_btn;
        private Label label4;
        private TextBox for_depatment_leader_input_employeeName_textBox;
        private Button for_department_leader_insert_and_update_btn;
        private Label label2;
        private GroupBox groupBox5;
        private Button depatment_name_update_btn;
        private ComboBox recent_department_list_combobox;
        private Label label6;
        private TextBox for_update_department_name_input_textbox;
        private Label label7;
        private Button for_department_leader_searching_result_to_combobox_btn;
        private ComboBox recent_department_name_list_for_leader_searching_combobox;
    }
}

