namespace DBP_TeamProject.Forms
{
    partial class FormMessage
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(640, 27);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "보내기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(640, 124);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "검색";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 31);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 3;
            label1.Text = "수신자";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 33);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 78);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 5;
            label2.Text = "제목";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 124);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 7;
            label3.Text = "검색";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 31);
            textBox2.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 168);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(740, 258);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 465);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(740, 129);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 437);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 10;
            label4.Text = "수신 메세지";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMessage";
            Text = "FormMessage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}