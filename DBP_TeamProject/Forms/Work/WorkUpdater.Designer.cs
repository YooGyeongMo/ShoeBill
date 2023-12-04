namespace DBP_TeamProject.Forms
{
    partial class WorkUpdater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_key = new TextBox();
            button_search = new Button();
            dataGridView_search = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_date = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            comboBox_emin = new ComboBox();
            comboBox_smin = new ComboBox();
            comboBox_etime = new ComboBox();
            comboBox_stime = new ComboBox();
            textBox_memo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button_update = new Button();
            comboBox_smallcategory = new ComboBox();
            comboBox_midcategory = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox1 = new GroupBox();
            label_bigcategory = new Label();
            label_workID = new Label();
            panel1 = new Panel();
            comboBox_user = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_search).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(530, 46);
            textBox_key.Margin = new Padding(3, 2, 3, 2);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(122, 27);
            textBox_key.TabIndex = 18;
            // 
            // button_search
            // 
            button_search.Location = new Point(721, 46);
            button_search.Margin = new Padding(3, 2, 3, 2);
            button_search.Name = "button_search";
            button_search.Size = new Size(100, 40);
            button_search.TabIndex = 16;
            button_search.Text = "검색";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // dataGridView_search
            // 
            dataGridView_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_search.Location = new Point(77, 98);
            dataGridView_search.Margin = new Padding(3, 2, 3, 2);
            dataGridView_search.Name = "dataGridView_search";
            dataGridView_search.RowHeadersWidth = 62;
            dataGridView_search.RowTemplate.Height = 33;
            dataGridView_search.Size = new Size(744, 244);
            dataGridView_search.TabIndex = 15;
            dataGridView_search.CellClick += dataGridView_search_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 52);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 14;
            label3.Text = "등록자";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "키워드";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 52);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 12;
            label1.Text = "날짜";
            // 
            // comboBox_date
            // 
            comboBox_date.FormattingEnabled = true;
            comboBox_date.Location = new Point(122, 46);
            comboBox_date.Margin = new Padding(3, 2, 3, 2);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Size = new Size(120, 28);
            comboBox_date.TabIndex = 10;
            comboBox_date.DropDown += comboBox_date_DropDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(669, 134);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 43;
            label10.Text = "분";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(669, 94);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 42;
            label9.Text = "분";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 134);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 41;
            label8.Text = "시";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(558, 96);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 40;
            label7.Text = "시";
            // 
            // comboBox_emin
            // 
            comboBox_emin.FormattingEnabled = true;
            comboBox_emin.Items.AddRange(new object[] { "00", "10", "20", "30", "40", "50" });
            comboBox_emin.Location = new Point(594, 128);
            comboBox_emin.Margin = new Padding(3, 2, 3, 2);
            comboBox_emin.Name = "comboBox_emin";
            comboBox_emin.Size = new Size(71, 28);
            comboBox_emin.TabIndex = 39;
            // 
            // comboBox_smin
            // 
            comboBox_smin.FormattingEnabled = true;
            comboBox_smin.Items.AddRange(new object[] { "00", "10", "20", "30", "40", "50" });
            comboBox_smin.Location = new Point(594, 90);
            comboBox_smin.Margin = new Padding(3, 2, 3, 2);
            comboBox_smin.Name = "comboBox_smin";
            comboBox_smin.Size = new Size(71, 28);
            comboBox_smin.TabIndex = 38;
            // 
            // comboBox_etime
            // 
            comboBox_etime.FormattingEnabled = true;
            comboBox_etime.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBox_etime.Location = new Point(483, 128);
            comboBox_etime.Margin = new Padding(3, 2, 3, 2);
            comboBox_etime.Name = "comboBox_etime";
            comboBox_etime.Size = new Size(71, 28);
            comboBox_etime.TabIndex = 37;
            // 
            // comboBox_stime
            // 
            comboBox_stime.FormattingEnabled = true;
            comboBox_stime.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBox_stime.Location = new Point(483, 90);
            comboBox_stime.Margin = new Padding(3, 2, 3, 2);
            comboBox_stime.Name = "comboBox_stime";
            comboBox_stime.Size = new Size(71, 28);
            comboBox_stime.TabIndex = 36;
            // 
            // textBox_memo
            // 
            textBox_memo.Location = new Point(483, 50);
            textBox_memo.Margin = new Padding(3, 2, 3, 2);
            textBox_memo.Name = "textBox_memo";
            textBox_memo.Size = new Size(211, 27);
            textBox_memo.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 134);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 34;
            label6.Text = "업무종료시간";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 94);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 33;
            label5.Text = "업무시작시간";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 54);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 32;
            label4.Text = "비고";
            // 
            // button_update
            // 
            button_update.Location = new Point(77, 626);
            button_update.Margin = new Padding(3, 2, 3, 2);
            button_update.Name = "button_update";
            button_update.Size = new Size(744, 64);
            button_update.TabIndex = 31;
            button_update.Text = "일일업무수정";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // comboBox_smallcategory
            // 
            comboBox_smallcategory.FormattingEnabled = true;
            comboBox_smallcategory.Location = new Point(157, 148);
            comboBox_smallcategory.Margin = new Padding(3, 2, 3, 2);
            comboBox_smallcategory.Name = "comboBox_smallcategory";
            comboBox_smallcategory.Size = new Size(154, 28);
            comboBox_smallcategory.TabIndex = 30;
            comboBox_smallcategory.DropDown += comboBox_smallcategory_DropDown;
            // 
            // comboBox_midcategory
            // 
            comboBox_midcategory.FormattingEnabled = true;
            comboBox_midcategory.Location = new Point(157, 108);
            comboBox_midcategory.Margin = new Padding(3, 2, 3, 2);
            comboBox_midcategory.Name = "comboBox_midcategory";
            comboBox_midcategory.Size = new Size(154, 28);
            comboBox_midcategory.TabIndex = 29;
            comboBox_midcategory.DropDown += comboBox_midcategory_DropDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 152);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 27;
            label11.Text = "소분류";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(76, 114);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 26;
            label12.Text = "중분류";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(76, 74);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 25;
            label13.Text = "대분류";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(545, 358);
            label14.Name = "label14";
            label14.Size = new Size(269, 20);
            label14.TabIndex = 45;
            label14.Text = "수정할 데이터가 있는 행을 선택하세요";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(107, 34);
            label15.Name = "label15";
            label15.Size = new Size(24, 20);
            label15.TabIndex = 47;
            label15.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_bigcategory);
            groupBox1.Controls.Add(label_workID);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox_emin);
            groupBox1.Controls.Add(comboBox_smin);
            groupBox1.Controls.Add(comboBox_etime);
            groupBox1.Controls.Add(comboBox_stime);
            groupBox1.Controls.Add(textBox_memo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox_smallcategory);
            groupBox1.Controls.Add(comboBox_midcategory);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(77, 406);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(744, 194);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "설정";
            // 
            // label_bigcategory
            // 
            label_bigcategory.AutoSize = true;
            label_bigcategory.Location = new Point(157, 74);
            label_bigcategory.Margin = new Padding(4, 0, 4, 0);
            label_bigcategory.Name = "label_bigcategory";
            label_bigcategory.Size = new Size(0, 20);
            label_bigcategory.TabIndex = 51;
            // 
            // label_workID
            // 
            label_workID.AutoSize = true;
            label_workID.Location = new Point(157, 34);
            label_workID.Margin = new Padding(4, 0, 4, 0);
            label_workID.Name = "label_workID";
            label_workID.Size = new Size(0, 20);
            label_workID.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox_user);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(comboBox_date);
            panel1.Controls.Add(button_update);
            panel1.Controls.Add(textBox_key);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button_search);
            panel1.Controls.Add(dataGridView_search);
            panel1.Location = new Point(72, 16);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 732);
            panel1.TabIndex = 49;
            // 
            // comboBox_user
            // 
            comboBox_user.FormattingEnabled = true;
            comboBox_user.Location = new Point(328, 46);
            comboBox_user.Margin = new Padding(3, 2, 3, 2);
            comboBox_user.Name = "comboBox_user";
            comboBox_user.Size = new Size(120, 28);
            comboBox_user.TabIndex = 49;
            comboBox_user.DropDown += comboBox_user_DropDown;
            // 
            // WorkUpdater
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 790);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WorkUpdater";
            Text = "WorkUpdater";
            ((System.ComponentModel.ISupportInitialize)dataGridView_search).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_key;
        private Button button_search;
        private DataGridView dataGridView_search;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_date;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox comboBox_emin;
        private ComboBox comboBox_smin;
        private ComboBox comboBox_etime;
        private ComboBox comboBox_stime;
        private TextBox textBox_memo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button_update;
        private ComboBox comboBox_smallcategory;
        private ComboBox comboBox_midcategory;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label_bigcategory;
        private Label label_workID;
        private ComboBox comboBox_user;
    }
}