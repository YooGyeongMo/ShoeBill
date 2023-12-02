namespace DBP_TeamProject.Forms
{
    partial class MasterDeleter
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
            groupBox2 = new GroupBox();
            button_deletemid = new Button();
            comboBox_midcategory = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button_deletesmall = new Button();
            comboBox_smallcategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox_bigcategory = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_deletemid);
            groupBox2.Controls.Add(comboBox_midcategory);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(43, 107);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(539, 111);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "중분류 삭제";
            // 
            // button_deletemid
            // 
            button_deletemid.Location = new Point(330, 35);
            button_deletemid.Margin = new Padding(2);
            button_deletemid.Name = "button_deletemid";
            button_deletemid.Size = new Size(182, 49);
            button_deletemid.TabIndex = 71;
            button_deletemid.Text = "중분류 삭제";
            button_deletemid.UseVisualStyleBackColor = true;
            button_deletemid.Click += button_deletemid_Click;
            // 
            // comboBox_midcategory
            // 
            comboBox_midcategory.FormattingEnabled = true;
            comboBox_midcategory.Location = new Point(38, 61);
            comboBox_midcategory.Margin = new Padding(2);
            comboBox_midcategory.Name = "comboBox_midcategory";
            comboBox_midcategory.Size = new Size(169, 23);
            comboBox_midcategory.TabIndex = 68;
            comboBox_midcategory.DropDown += comboBox_midcategory_DropDown;
            comboBox_midcategory.SelectedIndexChanged += comboBox_midcategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 65;
            label1.Text = "삭제할 중분류를 선택하세요";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_deletesmall);
            groupBox3.Controls.Add(comboBox_smallcategory);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(43, 238);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(539, 111);
            groupBox3.TabIndex = 82;
            groupBox3.TabStop = false;
            groupBox3.Text = "소분류 삭제";
            // 
            // button_deletesmall
            // 
            button_deletesmall.Location = new Point(330, 39);
            button_deletesmall.Margin = new Padding(2);
            button_deletesmall.Name = "button_deletesmall";
            button_deletesmall.Size = new Size(182, 49);
            button_deletesmall.TabIndex = 71;
            button_deletesmall.Text = "소분류 삭제";
            button_deletesmall.UseVisualStyleBackColor = true;
            button_deletesmall.Click += button_deletesmall_Click;
            // 
            // comboBox_smallcategory
            // 
            comboBox_smallcategory.FormattingEnabled = true;
            comboBox_smallcategory.Location = new Point(38, 65);
            comboBox_smallcategory.Margin = new Padding(2);
            comboBox_smallcategory.Name = "comboBox_smallcategory";
            comboBox_smallcategory.Size = new Size(169, 23);
            comboBox_smallcategory.TabIndex = 68;
            comboBox_smallcategory.DropDown += comboBox_smallcategory_DropDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 65;
            label2.Text = "삭제할 소분류를 선택하세요";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 84;
            label3.Text = "먼저 대분류를 선택해주세요";
            // 
            // comboBox_bigcategory
            // 
            comboBox_bigcategory.FormattingEnabled = true;
            comboBox_bigcategory.Location = new Point(206, 44);
            comboBox_bigcategory.Margin = new Padding(2);
            comboBox_bigcategory.Name = "comboBox_bigcategory";
            comboBox_bigcategory.Size = new Size(145, 23);
            comboBox_bigcategory.TabIndex = 83;
            comboBox_bigcategory.DropDown += comboBox_bigcategory_DropDown;
            comboBox_bigcategory.SelectedIndexChanged += comboBox_bigcategory_SelectedIndexChanged;
            // 
            // MasterDeleter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 419);
            Controls.Add(label3);
            Controls.Add(comboBox_bigcategory);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new Padding(2);
            Name = "MasterDeleter";
            Text = "MasterDeleter";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button button_deletemid;
        private ComboBox comboBox_midcategory;
        private Label label1;
        private GroupBox groupBox3;
        private Button button_deletesmall;
        private ComboBox comboBox_smallcategory;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_bigcategory;
    }
}