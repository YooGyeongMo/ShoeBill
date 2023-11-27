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
            groupBoxWork = new GroupBox();
            label8 = new Label();
            comboBoxMediumWork = new ComboBox();
            label7 = new Label();
            comboBoxLargeWork = new ComboBox();
            comboBoxSubWork = new ComboBox();
            label1 = new Label();
            groupBoxLastApprover = new GroupBox();
            comboBoxLastDepartment = new ComboBox();
            label3 = new Label();
            comboBoxLastApprover = new ComboBox();
            label6 = new Label();
            groupBoxApproveContent = new GroupBox();
            textBoxTitle = new TextBox();
            approveTitle = new Label();
            label2 = new Label();
            textBoxDescription = new TextBox();
            groupBoxFirstApprover = new GroupBox();
            comboBoxFirstDepartment = new ComboBox();
            label5 = new Label();
            comboBoxFirstApprover = new ComboBox();
            label4 = new Label();
            buttonApproveCreate = new Button();
            tabControl1.SuspendLayout();
            MyApproval.SuspendLayout();
            tabControlApproveData.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            NewApproval.SuspendLayout();
            groupBoxWork.SuspendLayout();
            groupBoxLastApprover.SuspendLayout();
            groupBoxApproveContent.SuspendLayout();
            groupBoxFirstApprover.SuspendLayout();
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
            tabControl1.Click += tabControl1_Click;
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
            buttonApproveDisagree.Click += buttonApproveDisagree_Click;
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
            buttonApproveAgree.Text = "결재 진행";
            buttonApproveAgree.UseVisualStyleBackColor = true;
            buttonApproveAgree.Click += buttonApproveAgree_Click;
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
            NewApproval.Controls.Add(groupBoxWork);
            NewApproval.Controls.Add(groupBoxLastApprover);
            NewApproval.Controls.Add(groupBoxApproveContent);
            NewApproval.Controls.Add(groupBoxFirstApprover);
            NewApproval.Controls.Add(buttonApproveCreate);
            NewApproval.Location = new Point(4, 30);
            NewApproval.Name = "NewApproval";
            NewApproval.Padding = new Padding(3);
            NewApproval.Size = new Size(781, 379);
            NewApproval.TabIndex = 0;
            NewApproval.Text = "신규결재등록";
            NewApproval.UseVisualStyleBackColor = true;
            // 
            // groupBoxWork
            // 
            groupBoxWork.Controls.Add(label8);
            groupBoxWork.Controls.Add(comboBoxMediumWork);
            groupBoxWork.Controls.Add(label7);
            groupBoxWork.Controls.Add(comboBoxLargeWork);
            groupBoxWork.Controls.Add(comboBoxSubWork);
            groupBoxWork.Controls.Add(label1);
            groupBoxWork.Location = new Point(248, 6);
            groupBoxWork.Name = "groupBoxWork";
            groupBoxWork.Size = new Size(283, 309);
            groupBoxWork.TabIndex = 25;
            groupBoxWork.TabStop = false;
            groupBoxWork.Text = "관련 업무";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 117);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 25;
            label8.Text = "중분류";
            // 
            // comboBoxMediumWork
            // 
            comboBoxMediumWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMediumWork.FormattingEnabled = true;
            comboBoxMediumWork.Location = new Point(105, 114);
            comboBoxMediumWork.Name = "comboBoxMediumWork";
            comboBoxMediumWork.Size = new Size(130, 29);
            comboBoxMediumWork.TabIndex = 24;
            comboBoxMediumWork.SelectedValueChanged += comboBoxMediumWork_SelectedValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 33);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 23;
            label7.Text = "대분류";
            // 
            // comboBoxLargeWork
            // 
            comboBoxLargeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLargeWork.FormattingEnabled = true;
            comboBoxLargeWork.Location = new Point(105, 30);
            comboBoxLargeWork.Name = "comboBoxLargeWork";
            comboBoxLargeWork.Size = new Size(130, 29);
            comboBoxLargeWork.TabIndex = 21;
            comboBoxLargeWork.SelectedValueChanged += comboBoxLargeWork_SelectedValueChanged;
            // 
            // comboBoxSubWork
            // 
            comboBoxSubWork.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubWork.FormattingEnabled = true;
            comboBoxSubWork.Location = new Point(105, 200);
            comboBoxSubWork.Name = "comboBoxSubWork";
            comboBoxSubWork.Size = new Size(130, 29);
            comboBoxSubWork.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 203);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 7;
            label1.Text = "소분류";
            // 
            // groupBoxLastApprover
            // 
            groupBoxLastApprover.Controls.Add(comboBoxLastDepartment);
            groupBoxLastApprover.Controls.Add(label3);
            groupBoxLastApprover.Controls.Add(comboBoxLastApprover);
            groupBoxLastApprover.Controls.Add(label6);
            groupBoxLastApprover.Location = new Point(537, 162);
            groupBoxLastApprover.Name = "groupBoxLastApprover";
            groupBoxLastApprover.Size = new Size(236, 153);
            groupBoxLastApprover.TabIndex = 23;
            groupBoxLastApprover.TabStop = false;
            groupBoxLastApprover.Text = "최종 결재자 선택";
            // 
            // comboBoxLastDepartment
            // 
            comboBoxLastDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLastDepartment.FormattingEnabled = true;
            comboBoxLastDepartment.Location = new Point(89, 44);
            comboBoxLastDepartment.Name = "comboBoxLastDepartment";
            comboBoxLastDepartment.Size = new Size(121, 29);
            comboBoxLastDepartment.TabIndex = 19;
            comboBoxLastDepartment.SelectedIndexChanged += comboBoxLastDepartment_SelectedIndexChanged;
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
            // comboBoxLastApprover
            // 
            comboBoxLastApprover.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLastApprover.FormattingEnabled = true;
            comboBoxLastApprover.Location = new Point(89, 108);
            comboBoxLastApprover.Name = "comboBoxLastApprover";
            comboBoxLastApprover.Size = new Size(121, 29);
            comboBoxLastApprover.TabIndex = 17;
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
            // groupBoxApproveContent
            // 
            groupBoxApproveContent.Controls.Add(textBoxTitle);
            groupBoxApproveContent.Controls.Add(approveTitle);
            groupBoxApproveContent.Controls.Add(label2);
            groupBoxApproveContent.Controls.Add(textBoxDescription);
            groupBoxApproveContent.Location = new Point(8, 6);
            groupBoxApproveContent.Name = "groupBoxApproveContent";
            groupBoxApproveContent.Size = new Size(234, 309);
            groupBoxApproveContent.TabIndex = 24;
            groupBoxApproveContent.TabStop = false;
            groupBoxApproveContent.Text = "결재 내용";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(94, 36);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(130, 29);
            textBoxTitle.TabIndex = 2;
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
            label2.Location = new Point(8, 86);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 11;
            label2.Text = "결재 내용";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(94, 83);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(130, 111);
            textBoxDescription.TabIndex = 12;
            // 
            // groupBoxFirstApprover
            // 
            groupBoxFirstApprover.Controls.Add(comboBoxFirstDepartment);
            groupBoxFirstApprover.Controls.Add(label5);
            groupBoxFirstApprover.Controls.Add(comboBoxFirstApprover);
            groupBoxFirstApprover.Controls.Add(label4);
            groupBoxFirstApprover.Location = new Point(537, 6);
            groupBoxFirstApprover.Name = "groupBoxFirstApprover";
            groupBoxFirstApprover.Size = new Size(236, 153);
            groupBoxFirstApprover.TabIndex = 22;
            groupBoxFirstApprover.TabStop = false;
            groupBoxFirstApprover.Text = "중간 결재자 선택";
            // 
            // comboBoxFirstDepartment
            // 
            comboBoxFirstDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFirstDepartment.FormattingEnabled = true;
            comboBoxFirstDepartment.Location = new Point(89, 44);
            comboBoxFirstDepartment.Name = "comboBoxFirstDepartment";
            comboBoxFirstDepartment.Size = new Size(121, 29);
            comboBoxFirstDepartment.TabIndex = 19;
            comboBoxFirstDepartment.SelectedIndexChanged += comboBoxFirstDepartment_SelectedIndexChanged;
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
            // comboBoxFirstApprover
            // 
            comboBoxFirstApprover.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFirstApprover.FormattingEnabled = true;
            comboBoxFirstApprover.Location = new Point(89, 111);
            comboBoxFirstApprover.Name = "comboBoxFirstApprover";
            comboBoxFirstApprover.Size = new Size(121, 29);
            comboBoxFirstApprover.TabIndex = 17;
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
            // buttonApproveCreate
            // 
            buttonApproveCreate.Location = new Point(8, 321);
            buttonApproveCreate.Name = "buttonApproveCreate";
            buttonApproveCreate.Size = new Size(770, 47);
            buttonApproveCreate.TabIndex = 0;
            buttonApproveCreate.Text = "결재 등록";
            buttonApproveCreate.UseVisualStyleBackColor = true;
            buttonApproveCreate.Click += ApproveCreateClick;
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
            groupBoxWork.ResumeLayout(false);
            groupBoxWork.PerformLayout();
            groupBoxLastApprover.ResumeLayout(false);
            groupBoxLastApprover.PerformLayout();
            groupBoxApproveContent.ResumeLayout(false);
            groupBoxApproveContent.PerformLayout();
            groupBoxFirstApprover.ResumeLayout(false);
            groupBoxFirstApprover.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage NewApproval;
        private TabPage MyApproval;
        private TextBox textBoxTitle;
        private Label approveTitle;
        private Button buttonApproveCreate;
        private Label label1;
        private TextBox textBoxDescription;
        private Label label2;
        private Label label4;
        private ComboBox comboBoxFirstApprover;
        private GroupBox groupBoxApproveContent;
        private ComboBox comboBoxLargeWork;
        private GroupBox groupBoxFirstApprover;
        private Button buttonApproveAgree;
        private Button buttonApproveContinue;
        private GroupBox groupBoxLastApprover;
        private ComboBox comboBoxLastDepartment;
        private Label label3;
        private ComboBox comboBoxLastApprover;
        private Label label6;
        private ComboBox comboBoxFirstDepartment;
        private Label label5;
        private TabControl tabControlApproveData;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button buttonApproveSearch;
        private Button buttonApproveDone;
        private Button buttonApproveDisagree;
        private DataGridView dataGridView2;
        private Label label7;
        private ComboBox comboBoxSubWork;
        private GroupBox groupBoxWork;
        private Label label8;
        private ComboBox comboBoxMediumWork;
    }
}