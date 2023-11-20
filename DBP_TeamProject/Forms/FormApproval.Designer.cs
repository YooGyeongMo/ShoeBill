namespace DBP_TeamProject.Forms
{
    partial class FormApproval
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
            tabControl1 = new TabControl();
            MyApproval = new TabPage();
            buttonApproveSearch = new Button();
            buttonApproveDone = new Button();
            buttonApproveDisagree = new Button();
            tabControlApproveData = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            buttonApproveAgree = new Button();
            buttonApproveContinue = new Button();
            NewApproval = new TabPage();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox5 = new ComboBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            approveTitle = new Label();
            label2 = new Label();
            comboBox4 = new ComboBox();
            textBox4 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            MyApproval.SuspendLayout();
            tabControlApproveData.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            NewApproval.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MyApproval);
            tabControl1.Controls.Add(NewApproval);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 413);
            tabControl1.TabIndex = 0;
            // 
            // MyApproval
            // 
            MyApproval.Controls.Add(buttonApproveSearch);
            MyApproval.Controls.Add(buttonApproveDone);
            MyApproval.Controls.Add(buttonApproveDisagree);
            MyApproval.Controls.Add(tabControlApproveData);
            MyApproval.Controls.Add(buttonApproveAgree);
            MyApproval.Controls.Add(buttonApproveContinue);
            MyApproval.Location = new Point(4, 30);
            MyApproval.Name = "MyApproval";
            MyApproval.Padding = new Padding(3);
            MyApproval.Size = new Size(781, 379);
            MyApproval.TabIndex = 1;
            MyApproval.Text = "나의 결재목록";
            MyApproval.UseVisualStyleBackColor = true;
            // 
            // buttonApproveSearch
            // 
            buttonApproveSearch.Location = new Point(8, 30);
            buttonApproveSearch.Name = "buttonApproveSearch";
            buttonApproveSearch.Size = new Size(205, 55);
            buttonApproveSearch.TabIndex = 6;
            buttonApproveSearch.Text = "전체 결재 검색";
            buttonApproveSearch.UseVisualStyleBackColor = true;
            buttonApproveSearch.Click += buttonApproveSearch_Click;
            // 
            // buttonApproveDone
            // 
            buttonApproveDone.Location = new Point(9, 171);
            buttonApproveDone.Name = "buttonApproveDone";
            buttonApproveDone.Size = new Size(205, 55);
            buttonApproveDone.TabIndex = 5;
            buttonApproveDone.Text = "결재 완료 검색";
            buttonApproveDone.UseVisualStyleBackColor = true;
            buttonApproveDone.Click += buttonApproveDone_Click;
            // 
            // buttonApproveDisagree
            // 
            buttonApproveDisagree.Location = new Point(8, 316);
            buttonApproveDisagree.Name = "buttonApproveDisagree";
            buttonApproveDisagree.Size = new Size(205, 55);
            buttonApproveDisagree.TabIndex = 4;
            buttonApproveDisagree.Text = "결재 반려";
            buttonApproveDisagree.UseVisualStyleBackColor = true;
            // 
            // tabControlApproveData
            // 
            tabControlApproveData.Controls.Add(tabPage1);
            tabControlApproveData.Controls.Add(tabPage2);
            tabControlApproveData.Location = new Point(216, 0);
            tabControlApproveData.Margin = new Padding(0);
            tabControlApproveData.Multiline = true;
            tabControlApproveData.Name = "tabControlApproveData";
            tabControlApproveData.SelectedIndex = 0;
            tabControlApproveData.Size = new Size(565, 383);
            tabControlApproveData.TabIndex = 3;
            tabControlApproveData.Selecting += tabControlApproveData_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(557, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "내가 등록한 결재";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(551, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(557, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "결재해야 할 업무";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(551, 343);
            dataGridView2.TabIndex = 0;
            // 
            // buttonApproveAgree
            // 
            buttonApproveAgree.Location = new Point(7, 255);
            buttonApproveAgree.Name = "buttonApproveAgree";
            buttonApproveAgree.Size = new Size(205, 55);
            buttonApproveAgree.TabIndex = 2;
            buttonApproveAgree.Text = "결재 승인";
            buttonApproveAgree.UseVisualStyleBackColor = true;
            // 
            // buttonApproveContinue
            // 
            buttonApproveContinue.Location = new Point(9, 110);
            buttonApproveContinue.Name = "buttonApproveContinue";
            buttonApproveContinue.Size = new Size(205, 55);
            buttonApproveContinue.TabIndex = 1;
            buttonApproveContinue.Text = "결재 중 검색";
            buttonApproveContinue.UseVisualStyleBackColor = true;
            buttonApproveContinue.Click += buttonApproveContinue_Click;
            // 
            // NewApproval
            // 
            NewApproval.Controls.Add(groupBox2);
            NewApproval.Controls.Add(groupBox3);
            NewApproval.Controls.Add(groupBox1);
            NewApproval.Controls.Add(button1);
            NewApproval.Location = new Point(4, 30);
            NewApproval.Name = "NewApproval";
            NewApproval.Padding = new Padding(3);
            NewApproval.Size = new Size(781, 379);
            NewApproval.TabIndex = 0;
            NewApproval.Text = "신규결재등록";
            NewApproval.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(537, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 153);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "중간 결재자 선택";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 47);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 20;
            label3.Text = "부서";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(89, 108);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 29);
            comboBox5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 111);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 18;
            label6.Text = "결재자";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(approveTitle);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(8, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 309);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "결재 내용";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(94, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 29);
            textBox1.TabIndex = 2;
            // 
            // approveTitle
            // 
            approveTitle.AutoSize = true;
            approveTitle.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            approveTitle.Location = new Point(8, 39);
            approveTitle.Name = "approveTitle";
            approveTitle.Size = new Size(80, 21);
            approveTitle.TabIndex = 1;
            approveTitle.Text = "결재 제목";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 173);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 11;
            label2.Text = "결재 내용";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(94, 111);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(130, 29);
            comboBox4.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(94, 170);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 111);
            textBox4.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 111);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 7;
            label1.Text = "관련 업무";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(270, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 153);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "중간 결재자 선택";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(89, 44);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 29);
            comboBox3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 47);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 20;
            label5.Text = "부서";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(89, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 114);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 18;
            label4.Text = "결재자";
            // 
            // button1
            // 
            button1.Location = new Point(8, 321);
            button1.Name = "button1";
            button1.Size = new Size(770, 47);
            button1.TabIndex = 0;
            button1.Text = "결재 등록";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 413);
            Controls.Add(tabControl1);
            Name = "FormApproval";
            Text = "FormApproval";
            Load += FormApproval_Load;
            tabControl1.ResumeLayout(false);
            MyApproval.ResumeLayout(false);
            tabControlApproveData.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            NewApproval.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage NewApproval;
        private TabPage MyApproval;
        private TextBox textBox1;
        private Label approveTitle;
        private Button button1;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
        private Label label4;
        private ComboBox comboBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox4;
        private GroupBox groupBox1;
        private Button buttonApproveAgree;
        private Button buttonApproveContinue;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox5;
        private Label label6;
        private ComboBox comboBox3;
        private Label label5;
        private TabControl tabControlApproveData;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button buttonApproveSearch;
        private Button buttonApproveDone;
        private Button buttonApproveDisagree;
        private DataGridView dataGridView2;
    }
}