namespace DBP_TeamProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            Btnchat = new Button();
            Btbmessage = new Button();
            Btnapproval = new Button();
            Btnwork = new Button();
            Btnemployee = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            BtnCloseChlidFrom = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            pictureBox = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(Btnchat);
            panelMenu.Controls.Add(Btbmessage);
            panelMenu.Controls.Add(Btnapproval);
            panelMenu.Controls.Add(Btnwork);
            panelMenu.Controls.Add(Btnemployee);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(221, 768);
            panelMenu.TabIndex = 0;
            // 
            // Btnchat
            // 
            Btnchat.Dock = DockStyle.Top;
            Btnchat.FlatAppearance.BorderSize = 0;
            Btnchat.FlatStyle = FlatStyle.Flat;
            Btnchat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnchat.ForeColor = Color.Gainsboro;
            Btnchat.Image = Properties.Resources.채팅;
            Btnchat.ImageAlign = ContentAlignment.MiddleLeft;
            Btnchat.Location = new Point(0, 320);
            Btnchat.Name = "Btnchat";
            Btnchat.Padding = new Padding(11, 0, 0, 0);
            Btnchat.Size = new Size(221, 60);
            Btnchat.TabIndex = 5;
            Btnchat.Text = "   채팅";
            Btnchat.TextAlign = ContentAlignment.MiddleLeft;
            Btnchat.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btnchat.UseVisualStyleBackColor = true;
            Btnchat.Click += Btnchat_Click;
            // 
            // Btbmessage
            // 
            Btbmessage.Dock = DockStyle.Top;
            Btbmessage.FlatAppearance.BorderSize = 0;
            Btbmessage.FlatStyle = FlatStyle.Flat;
            Btbmessage.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btbmessage.ForeColor = Color.Gainsboro;
            Btbmessage.Image = Properties.Resources.쪽지;
            Btbmessage.ImageAlign = ContentAlignment.MiddleLeft;
            Btbmessage.Location = new Point(0, 260);
            Btbmessage.Name = "Btbmessage";
            Btbmessage.Padding = new Padding(11, 0, 0, 0);
            Btbmessage.Size = new Size(221, 60);
            Btbmessage.TabIndex = 4;
            Btbmessage.Text = "   쪽지";
            Btbmessage.TextAlign = ContentAlignment.MiddleLeft;
            Btbmessage.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btbmessage.UseVisualStyleBackColor = true;
            Btbmessage.Click += Btbmessage_Click;
            // 
            // Btnapproval
            // 
            Btnapproval.Dock = DockStyle.Top;
            Btnapproval.FlatAppearance.BorderSize = 0;
            Btnapproval.FlatStyle = FlatStyle.Flat;
            Btnapproval.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnapproval.ForeColor = Color.Gainsboro;
            Btnapproval.Image = Properties.Resources.결제;
            Btnapproval.ImageAlign = ContentAlignment.MiddleLeft;
            Btnapproval.Location = new Point(0, 200);
            Btnapproval.Name = "Btnapproval";
            Btnapproval.Padding = new Padding(11, 0, 0, 0);
            Btnapproval.Size = new Size(221, 60);
            Btnapproval.TabIndex = 3;
            Btnapproval.Text = "   결재";
            Btnapproval.TextAlign = ContentAlignment.MiddleLeft;
            Btnapproval.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btnapproval.UseVisualStyleBackColor = true;
            Btnapproval.Click += Btnapproval_Click;
            // 
            // Btnwork
            // 
            Btnwork.Dock = DockStyle.Top;
            Btnwork.FlatAppearance.BorderSize = 0;
            Btnwork.FlatStyle = FlatStyle.Flat;
            Btnwork.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnwork.ForeColor = Color.Gainsboro;
            Btnwork.Image = Properties.Resources.업무;
            Btnwork.ImageAlign = ContentAlignment.MiddleLeft;
            Btnwork.Location = new Point(0, 140);
            Btnwork.Name = "Btnwork";
            Btnwork.Padding = new Padding(11, 0, 0, 0);
            Btnwork.Size = new Size(221, 60);
            Btnwork.TabIndex = 2;
            Btnwork.Text = "   업무";
            Btnwork.TextAlign = ContentAlignment.MiddleLeft;
            Btnwork.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btnwork.UseVisualStyleBackColor = true;
            Btnwork.Click += Btnwork_Click;
            // 
            // Btnemployee
            // 
            Btnemployee.Dock = DockStyle.Top;
            Btnemployee.FlatAppearance.BorderSize = 0;
            Btnemployee.FlatStyle = FlatStyle.Flat;
            Btnemployee.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnemployee.ForeColor = Color.Gainsboro;
            Btnemployee.Image = Properties.Resources.인사;
            Btnemployee.ImageAlign = ContentAlignment.MiddleLeft;
            Btnemployee.Location = new Point(0, 80);
            Btnemployee.Name = "Btnemployee";
            Btnemployee.Padding = new Padding(11, 0, 0, 0);
            Btnemployee.Size = new Size(221, 60);
            Btnemployee.TabIndex = 1;
            Btnemployee.Text = "   인사";
            Btnemployee.TextAlign = ContentAlignment.MiddleLeft;
            Btnemployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btnemployee.UseVisualStyleBackColor = true;
            Btnemployee.Click += Btnemployee_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(221, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "회사관리프로그램";
            label1.Click += label1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(BtnCloseChlidFrom);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(221, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1128, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // BtnCloseChlidFrom
            // 
            BtnCloseChlidFrom.Dock = DockStyle.Left;
            BtnCloseChlidFrom.FlatAppearance.BorderSize = 0;
            BtnCloseChlidFrom.FlatStyle = FlatStyle.Flat;
            BtnCloseChlidFrom.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCloseChlidFrom.ForeColor = Color.White;
            BtnCloseChlidFrom.Location = new Point(0, 0);
            BtnCloseChlidFrom.Name = "BtnCloseChlidFrom";
            BtnCloseChlidFrom.Size = new Size(113, 80);
            BtnCloseChlidFrom.TabIndex = 1;
            BtnCloseChlidFrom.Text = "로그아웃";
            BtnCloseChlidFrom.UseVisualStyleBackColor = true;
            BtnCloseChlidFrom.Click += BtnCloseChlidFrom_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1045, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 40);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "ㅡ";
            btnMinimize.TextAlign = ContentAlignment.MiddleRight;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1088, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(492, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(103, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Controls.Add(pictureBox);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(221, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1128, 688);
            panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Properties.Resources.ShoBill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1128, 688);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 768);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "회사관리 프로그램";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button Btnemployee;
        private Panel panelLogo;
        private Button Btnchat;
        private Button Btbmessage;
        private Button Btnapproval;
        private Button Btnwork;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Button BtnCloseChlidFrom;
        private Button btnClose;
        private Button btnMinimize;
        private Panel panelDesktopPanel;
        private PictureBox pictureBox;
    }
}