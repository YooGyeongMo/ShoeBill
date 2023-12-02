using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DBP_TeamProject.Forms
{
    partial class MasterUpdater
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
            comboBox_smallcategory = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_midcategory = new TextBox();
            textBox_small = new TextBox();
            button_updatemid = new Button();
            button_updatesmall = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBox_bigcategory = new ComboBox();
            comboBox_midcategory = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_smallcategory
            // 
            comboBox_smallcategory.FormattingEnabled = true;
            comboBox_smallcategory.Location = new Point(209, 36);
            comboBox_smallcategory.Margin = new Padding(2);
            comboBox_smallcategory.Name = "comboBox_smallcategory";
            comboBox_smallcategory.Size = new Size(145, 23);
            comboBox_smallcategory.TabIndex = 52;
            comboBox_smallcategory.DropDown += comboBox_smallcategory_DropDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 40);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(159, 15);
            label11.TabIndex = 49;
            label11.Text = "수정할 소분류를 선택하세요";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 84);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(159, 15);
            label12.TabIndex = 48;
            label12.Text = "수정할 중분류를 선택하세요";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 59;
            label2.Text = "수정할 중분류를 입력하세요";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 60;
            label3.Text = "수정할 소분류를 입력하세요";
            // 
            // textBox_midcategory
            // 
            textBox_midcategory.Location = new Point(209, 121);
            textBox_midcategory.Margin = new Padding(2);
            textBox_midcategory.Name = "textBox_midcategory";
            textBox_midcategory.Size = new Size(145, 23);
            textBox_midcategory.TabIndex = 61;
            // 
            // textBox_small
            // 
            textBox_small.AcceptsReturn = true;
            textBox_small.Location = new Point(209, 75);
            textBox_small.Margin = new Padding(2);
            textBox_small.Name = "textBox_small";
            textBox_small.Size = new Size(145, 23);
            textBox_small.TabIndex = 62;
            // 
            // button_updatemid
            // 
            button_updatemid.Location = new Point(436, 111);
            button_updatemid.Margin = new Padding(2);
            button_updatemid.Name = "button_updatemid";
            button_updatemid.Size = new Size(129, 40);
            button_updatemid.TabIndex = 63;
            button_updatemid.Text = "중분류 수정";
            button_updatemid.UseVisualStyleBackColor = true;
            button_updatemid.Click += button_updatemid_Click;
            // 
            // button_updatesmall
            // 
            button_updatesmall.Location = new Point(436, 65);
            button_updatesmall.Margin = new Padding(2);
            button_updatesmall.Name = "button_updatesmall";
            button_updatesmall.Size = new Size(129, 40);
            button_updatesmall.TabIndex = 64;
            button_updatesmall.Text = "소분류 수정";
            button_updatesmall.UseVisualStyleBackColor = true;
            button_updatesmall.Click += button_updatesmall_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox_bigcategory);
            groupBox2.Controls.Add(button_updatemid);
            groupBox2.Controls.Add(textBox_midcategory);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox_midcategory);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(28, 33);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(584, 176);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "중분류 수정";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 65;
            label1.Text = "먼저 대분류를 선택해주세요";
            // 
            // comboBox_bigcategory
            // 
            comboBox_bigcategory.FormattingEnabled = true;
            comboBox_bigcategory.Location = new Point(209, 39);
            comboBox_bigcategory.Margin = new Padding(2);
            comboBox_bigcategory.Name = "comboBox_bigcategory";
            comboBox_bigcategory.Size = new Size(145, 23);
            comboBox_bigcategory.TabIndex = 64;
            comboBox_bigcategory.DropDown += comboBox_bigcategory_DropDown;
            comboBox_bigcategory.SelectedIndexChanged += comboBox_bigcategory_SelectedIndexChanged;
            // 
            // comboBox_midcategory
            // 
            comboBox_midcategory.FormattingEnabled = true;
            comboBox_midcategory.Location = new Point(209, 81);
            comboBox_midcategory.Margin = new Padding(2);
            comboBox_midcategory.Name = "comboBox_midcategory";
            comboBox_midcategory.Size = new Size(145, 23);
            comboBox_midcategory.TabIndex = 51;
            comboBox_midcategory.DropDown += comboBox_midcategory_DropDown;
            comboBox_midcategory.SelectedIndexChanged += comboBox_midcategory_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_updatesmall);
            groupBox3.Controls.Add(textBox_small);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(comboBox_smallcategory);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(28, 232);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(584, 128);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "소분류 수정";
            // 
            // MasterUpdater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 397);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new Padding(2);
            Name = "MasterUpdater";
            Text = "MasterUpdater";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox_smallcategory;
        private Label label11;
        private Label label12;
        private Label label2;
        private Label label3;
        private TextBox textBox_midcategory;
        private TextBox textBox_small;
        private Button button_updatemid;
        private Button button_updatesmall;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox_midcategory;
        private Label label1;
        private ComboBox comboBox_bigcategory;
    }
}