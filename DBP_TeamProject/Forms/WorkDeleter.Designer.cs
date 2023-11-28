namespace DBP_TeamProject.Forms
{
    partial class WorkDeleter
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
            button_close = new Button();
            button_search = new Button();
            dataGridView_search = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_user = new ComboBox();
            comboBox_date = new ComboBox();
            button_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_search).BeginInit();
            SuspendLayout();
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(272, 8);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(135, 31);
            textBox_key.TabIndex = 18;
            // 
            // button_close
            // 
            button_close.Location = new Point(814, 7);
            button_close.Name = "button_close";
            button_close.Size = new Size(84, 33);
            button_close.TabIndex = 17;
            button_close.Text = "종료";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // button_search
            // 
            button_search.Location = new Point(645, 8);
            button_search.Name = "button_search";
            button_search.Size = new Size(73, 33);
            button_search.TabIndex = 16;
            button_search.Text = "검색";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // dataGridView_search
            // 
            dataGridView_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_search.Location = new Point(12, 65);
            dataGridView_search.Name = "dataGridView_search";
            dataGridView_search.RowHeadersWidth = 62;
            dataGridView_search.RowTemplate.Height = 33;
            dataGridView_search.Size = new Size(882, 373);
            dataGridView_search.TabIndex = 15;
            dataGridView_search.CellContentClick += dataGridView_search_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 11);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 14;
            label3.Text = "등록자";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 11);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 13;
            label2.Text = "키워드";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 12;
            label1.Text = "날짜";
            // 
            // comboBox_user
            // 
            comboBox_user.FormattingEnabled = true;
            comboBox_user.Location = new Point(485, 8);
            comboBox_user.Name = "comboBox_user";
            comboBox_user.Size = new Size(154, 33);
            comboBox_user.TabIndex = 11;
            // 
            // comboBox_date
            // 
            comboBox_date.FormattingEnabled = true;
            comboBox_date.Location = new Point(63, 8);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Size = new Size(133, 33);
            comboBox_date.TabIndex = 10;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(724, 7);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(84, 33);
            button_delete.TabIndex = 19;
            button_delete.Text = "삭제";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // WorkDeleter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(button_delete);
            Controls.Add(textBox_key);
            Controls.Add(button_close);
            Controls.Add(button_search);
            Controls.Add(dataGridView_search);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_user);
            Controls.Add(comboBox_date);
            Name = "WorkDeleter";
            Text = "WorkDeleter";
            Load += WorkDeleter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_search).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_key;
        private Button button_close;
        private Button button_search;
        private DataGridView dataGridView_search;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_user;
        private ComboBox comboBox_date;
        private Button button_delete;
    }
}