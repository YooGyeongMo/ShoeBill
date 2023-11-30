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
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_deletemid);
            groupBox2.Controls.Add(comboBox_midcategory);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 172);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "중분류 삭제";
            // 
            // button_deletemid
            // 
            button_deletemid.Location = new Point(471, 20);
            button_deletemid.Name = "button_deletemid";
            button_deletemid.Size = new Size(293, 100);
            button_deletemid.TabIndex = 71;
            button_deletemid.Text = "중분류 삭제";
            button_deletemid.UseVisualStyleBackColor = true;
            button_deletemid.Click += button_deletemid_Click;
            // 
            // comboBox_midcategory
            // 
            comboBox_midcategory.FormattingEnabled = true;
            comboBox_midcategory.Location = new Point(6, 100);
            comboBox_midcategory.Name = "comboBox_midcategory";
            comboBox_midcategory.Size = new Size(240, 33);
            comboBox_midcategory.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 65;
            label1.Text = "삭제할 중분류를 선택하세요";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_deletesmall);
            groupBox3.Controls.Add(comboBox_smallcategory);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(770, 151);
            groupBox3.TabIndex = 82;
            groupBox3.TabStop = false;
            groupBox3.Text = "소분류 삭제";
            // 
            // button_deletesmall
            // 
            button_deletesmall.Location = new Point(471, 10);
            button_deletesmall.Name = "button_deletesmall";
            button_deletesmall.Size = new Size(293, 100);
            button_deletesmall.TabIndex = 71;
            button_deletesmall.Text = "소분류 삭제";
            button_deletesmall.UseVisualStyleBackColor = true;
            button_deletesmall.Click += button_deletesmall_Click;
            // 
            // comboBox_smallcategory
            // 
            comboBox_smallcategory.FormattingEnabled = true;
            comboBox_smallcategory.Location = new Point(6, 60);
            comboBox_smallcategory.Name = "comboBox_smallcategory";
            comboBox_smallcategory.Size = new Size(240, 33);
            comboBox_smallcategory.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 65;
            label2.Text = "삭제할 소분류를 선택하세요";
            // 
            // MasterDeleter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "MasterDeleter";
            Text = "MasterDeleter";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
    }
}