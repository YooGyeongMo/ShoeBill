namespace DBP_TeamProject.Forms
{
    partial class Address
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
            dataGridView1 = new DataGridView();
            LoadButton = new Button();
            roadAddrTextBox = new TextBox();
            selectButton = new Button();
            label1 = new Label();
            label2 = new Label();
            zipCodeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(530, 197);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(445, 26);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(112, 52);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "조회하기";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // roadAddrTextBox
            // 
            roadAddrTextBox.Location = new Point(102, 26);
            roadAddrTextBox.Name = "roadAddrTextBox";
            roadAddrTextBox.Size = new Size(325, 23);
            roadAddrTextBox.TabIndex = 2;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(565, 244);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(102, 46);
            selectButton.TabIndex = 3;
            selectButton.Text = "선택하기";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "도로명 주소";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "우편번호";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(102, 55);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(91, 23);
            zipCodeTextBox.TabIndex = 5;
            // 
            // Address
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 304);
            Controls.Add(label2);
            Controls.Add(zipCodeTextBox);
            Controls.Add(label1);
            Controls.Add(selectButton);
            Controls.Add(roadAddrTextBox);
            Controls.Add(LoadButton);
            Controls.Add(dataGridView1);
            Name = "Address";
            Text = "주소";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button LoadButton;
        private TextBox roadAddrTextBox;
        private Button selectButton;
        private Label label1;
        private Label label2;
        private TextBox zipCodeTextBox;
    }
}