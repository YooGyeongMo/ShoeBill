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
            button_updatesmall = new Button();
            button_updatemid = new Button();
            button_deletebig = new Button();
            comboBox_bigcategory = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button_deletemid = new Button();
            comboBox_midcategory = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button_deletesmall = new Button();
            comboBox_smallcategory = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button_updatesmall
            // 
            button_updatesmall.Location = new Point(483, 321);
            button_updatesmall.Name = "button_updatesmall";
            button_updatesmall.Size = new Size(242, 53);
            button_updatesmall.TabIndex = 79;
            button_updatesmall.Text = "소분류 수정";
            button_updatesmall.UseVisualStyleBackColor = true;
            // 
            // button_updatemid
            // 
            button_updatemid.Location = new Point(483, 178);
            button_updatemid.Name = "button_updatemid";
            button_updatemid.Size = new Size(242, 53);
            button_updatemid.TabIndex = 78;
            button_updatemid.Text = "중분류 수정";
            button_updatemid.UseVisualStyleBackColor = true;
            // 
            // button_deletebig
            // 
            button_deletebig.Location = new Point(471, 14);
            button_deletebig.Name = "button_deletebig";
            button_deletebig.Size = new Size(293, 100);
            button_deletebig.TabIndex = 71;
            button_deletebig.Text = "대분류 삭제";
            button_deletebig.UseVisualStyleBackColor = true;
            button_deletebig.Click += button_deletebig_Click;
            // 
            // comboBox_bigcategory
            // 
            comboBox_bigcategory.FormattingEnabled = true;
            comboBox_bigcategory.Location = new Point(6, 56);
            comboBox_bigcategory.Name = "comboBox_bigcategory";
            comboBox_bigcategory.Size = new Size(240, 33);
            comboBox_bigcategory.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 324);
            label11.Name = "label11";
            label11.Size = new Size(240, 25);
            label11.TabIndex = 67;
            label11.Text = "삭제할 소분류를 선택하세요";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 178);
            label12.Name = "label12";
            label12.Size = new Size(240, 25);
            label12.TabIndex = 66;
            label12.Text = "삭제할 중분류를 선택하세요";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 28);
            label13.Name = "label13";
            label13.Size = new Size(240, 25);
            label13.TabIndex = 65;
            label13.Text = "삭제할 대분류를 선택하세요";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_deletebig);
            groupBox1.Controls.Add(comboBox_bigcategory);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 120);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "대분류 삭제";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_deletemid);
            groupBox2.Controls.Add(comboBox_midcategory);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 120);
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
            comboBox_midcategory.Location = new Point(6, 60);
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
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(770, 120);
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
            Controls.Add(groupBox1);
            Controls.Add(button_updatesmall);
            Controls.Add(button_updatemid);
            Controls.Add(label11);
            Controls.Add(label12);
            Name = "MasterDeleter";
            Text = "MasterDeleter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_updatesmall;
        private Button button_updatemid;
        private Button button_deletebig;
        private ComboBox comboBox_bigcategory;
        private Label label11;
        private Label label12;
        private Label label13;
        private GroupBox groupBox1;
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