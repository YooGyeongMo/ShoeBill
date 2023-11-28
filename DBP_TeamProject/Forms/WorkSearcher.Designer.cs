namespace DBP_TeamProject
{
    partial class WorkSearcher
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
            comboBox_date = new ComboBox();
            comboBox_user = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView_search = new DataGridView();
            button_search = new Button();
            button_close = new Button();
            textBox_key = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_search).BeginInit();
            SuspendLayout();
            // 
            // comboBox_date
            // 
            comboBox_date.FormattingEnabled = true;
            comboBox_date.Location = new Point(66, 12);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Size = new Size(133, 33);
            comboBox_date.TabIndex = 0;
            // 
            // comboBox_user
            // 
            comboBox_user.FormattingEnabled = true;
            comboBox_user.Location = new Point(488, 12);
            comboBox_user.Name = "comboBox_user";
            comboBox_user.Size = new Size(154, 33);
            comboBox_user.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 3;
            label1.Text = "날짜";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 15);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "키워드";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 5;
            label3.Text = "등록자";
            // 
            // dataGridView_search
            // 
            dataGridView_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_search.Location = new Point(15, 69);
            dataGridView_search.Name = "dataGridView_search";
            dataGridView_search.RowHeadersWidth = 62;
            dataGridView_search.RowTemplate.Height = 33;
            dataGridView_search.Size = new Size(796, 369);
            dataGridView_search.TabIndex = 6;
            // 
            // button_search
            // 
            button_search.Location = new Point(648, 12);
            button_search.Name = "button_search";
            button_search.Size = new Size(73, 33);
            button_search.TabIndex = 7;
            button_search.Text = "검색";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // button_close
            // 
            button_close.Location = new Point(727, 12);
            button_close.Name = "button_close";
            button_close.Size = new Size(84, 33);
            button_close.TabIndex = 8;
            button_close.Text = "종료";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(275, 12);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(135, 31);
            textBox_key.TabIndex = 9;
            // 
            // WorkSearcher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(textBox_key);
            Controls.Add(button_close);
            Controls.Add(button_search);
            Controls.Add(dataGridView_search);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_user);
            Controls.Add(comboBox_date);
            Name = "WorkSearcher";
            Text = "WorkSearcher";
            Load += WorkSearcher_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_search).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_date;
        private ComboBox comboBox_user;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView_search;
        private Button button_search;
        private Button button_close;
        private TextBox textBox_key;
    }
}