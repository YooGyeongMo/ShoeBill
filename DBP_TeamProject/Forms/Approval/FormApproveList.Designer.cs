namespace DBP_TeamProject.Forms.Approval
{
    partial class FormApproveList
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBoxApprover = new ComboBox();
            label4 = new Label();
            comboBoxApproveType = new ComboBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 54);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "결재날짜";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 22);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "결재자";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 54);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 8;
            label1.Text = "반려메모";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 184);
            textBox1.TabIndex = 7;
            // 
            // comboBoxApprover
            // 
            comboBoxApprover.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxApprover.FormattingEnabled = true;
            comboBoxApprover.Location = new Point(260, 19);
            comboBoxApprover.Name = "comboBoxApprover";
            comboBoxApprover.Size = new Size(171, 23);
            comboBoxApprover.TabIndex = 6;
            comboBoxApprover.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 22);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 13;
            label4.Text = "결재 타입";
            // 
            // comboBoxApproveType
            // 
            comboBoxApproveType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxApproveType.FormattingEnabled = true;
            comboBoxApproveType.Location = new Point(81, 19);
            comboBoxApproveType.Name = "comboBoxApproveType";
            comboBoxApproveType.Size = new Size(118, 23);
            comboBoxApproveType.TabIndex = 12;
            comboBoxApproveType.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 184);
            listBox1.TabIndex = 14;
            listBox1.Click += listBox1_Click;
            // 
            // FormApproveList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 272);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(comboBoxApproveType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBoxApprover);
            Name = "FormApproveList";
            Text = "FormApproveList";
            Load += FormApproveList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBoxApprover;
        private Label label4;
        private ComboBox comboBoxApproveType;
        private ListBox listBox1;
    }
}