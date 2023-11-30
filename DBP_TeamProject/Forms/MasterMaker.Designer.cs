namespace DBP_TeamProject.Forms
{
    partial class MasterMaker
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            comboBox_midcategory = new ComboBox();
            textBox_small = new TextBox();
            button_addsmall = new Button();
            label_mid = new Label();
            comboBox_bigcategory = new ComboBox();
            textBox_mid = new TextBox();
            button_addmid = new Button();
            label_big = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 121);
            label2.Name = "label2";
            label2.Size = new Size(258, 25);
            label2.TabIndex = 2;
            label2.Text = "추가할 중분류를 입력해주세요";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(240, 25);
            label3.TabIndex = 5;
            label3.Text = "먼저 대분류를 선택해주세요";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 120);
            label4.Name = "label4";
            label4.Size = new Size(258, 25);
            label4.TabIndex = 8;
            label4.Text = "추가할 소분류를 입력해주세요";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(240, 25);
            label6.TabIndex = 11;
            label6.Text = "먼저 중분류를 선택해주세요";
            // 
            // comboBox_midcategory
            // 
            comboBox_midcategory.FormattingEnabled = true;
            comboBox_midcategory.Location = new Point(282, 26);
            comboBox_midcategory.Name = "comboBox_midcategory";
            comboBox_midcategory.Size = new Size(206, 33);
            comboBox_midcategory.TabIndex = 12;
            comboBox_midcategory.SelectedIndexChanged += comboBox_midcategory_SelectedIndexChanged;
            // 
            // textBox_small
            // 
            textBox_small.Location = new Point(282, 125);
            textBox_small.Name = "textBox_small";
            textBox_small.Size = new Size(206, 31);
            textBox_small.TabIndex = 13;
            // 
            // button_addsmall
            // 
            button_addsmall.Location = new Point(585, 21);
            button_addsmall.Name = "button_addsmall";
            button_addsmall.Size = new Size(184, 69);
            button_addsmall.TabIndex = 14;
            button_addsmall.Text = "소분류 추가";
            button_addsmall.UseVisualStyleBackColor = true;
            button_addsmall.Click += button_addsmall_Click;
            // 
            // label_mid
            // 
            label_mid.AutoSize = true;
            label_mid.Location = new Point(506, 29);
            label_mid.Name = "label_mid";
            label_mid.Size = new Size(58, 25);
            label_mid.TabIndex = 16;
            label_mid.Text = "더미2";
            label_mid.Visible = false;
            // 
            // comboBox_bigcategory
            // 
            comboBox_bigcategory.FormattingEnabled = true;
            comboBox_bigcategory.Location = new Point(289, 30);
            comboBox_bigcategory.Name = "comboBox_bigcategory";
            comboBox_bigcategory.Size = new Size(206, 33);
            comboBox_bigcategory.TabIndex = 4;
            comboBox_bigcategory.SelectedIndexChanged += comboBox_bigcategory_SelectedIndexChanged;
            // 
            // textBox_mid
            // 
            textBox_mid.Location = new Point(289, 121);
            textBox_mid.Name = "textBox_mid";
            textBox_mid.Size = new Size(206, 31);
            textBox_mid.TabIndex = 6;
            // 
            // button_addmid
            // 
            button_addmid.Location = new Point(592, 21);
            button_addmid.Name = "button_addmid";
            button_addmid.Size = new Size(184, 67);
            button_addmid.TabIndex = 7;
            button_addmid.Text = "중분류 추가";
            button_addmid.UseVisualStyleBackColor = true;
            button_addmid.Click += button_addmid_Click;
            // 
            // label_big
            // 
            label_big.AutoSize = true;
            label_big.Location = new Point(513, 33);
            label_big.Name = "label_big";
            label_big.Size = new Size(58, 25);
            label_big.TabIndex = 15;
            label_big.Text = "더미1";
            label_big.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_big);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_mid);
            groupBox2.Controls.Add(button_addmid);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox_bigcategory);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 160);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "중분류 추가";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(button_addsmall);
            groupBox3.Controls.Add(label_mid);
            groupBox3.Controls.Add(textBox_small);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBox_midcategory);
            groupBox3.Location = new Point(12, 178);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(769, 160);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "소분류 추가";
            // 
            // MasterMaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "MasterMaker";
            Text = "MasterMaker";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox comboBox_midcategory;
        private TextBox textBox_small;
        private Button button_addsmall;
        private Label label_mid;
        private ComboBox comboBox_bigcategory;
        private TextBox textBox_mid;
        private Button button_addmid;
        private Label label_big;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}