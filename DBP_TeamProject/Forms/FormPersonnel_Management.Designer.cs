﻿namespace DBP_TeamProject.Forms
{
    partial class FormPersonnel_Management
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
            loadPanel = new Panel();
            menuStrip = new MenuStrip();
            출근부관리ToolStripMenuItem = new ToolStripMenuItem();
            사원등록ToolStripMenuItem = new ToolStripMenuItem();
            사원관리ToolStripMenuItem = new ToolStripMenuItem();
            사원검색ToolStripMenuItem = new ToolStripMenuItem();
            사원수정ToolStripMenuItem = new ToolStripMenuItem();
            부서관리ToolStripMenuItem = new ToolStripMenuItem();
            부서등록수정삭제ToolStripMenuItem1 = new ToolStripMenuItem();
            부서현황조회ToolStripMenuItem = new ToolStripMenuItem();
            급여관리ToolStripMenuItem = new ToolStripMenuItem();
            인사조직ToolStripMenuItem = new ToolStripMenuItem();
            급여계산ToolStripMenuItem = new ToolStripMenuItem();
            급여내역ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // loadPanel
            // 
            loadPanel.Location = new Point(0, 27);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(800, 420);
            loadPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { 출근부관리ToolStripMenuItem, 사원등록ToolStripMenuItem, 사원관리ToolStripMenuItem, 부서관리ToolStripMenuItem, 급여관리ToolStripMenuItem, 인사조직ToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // 출근부관리ToolStripMenuItem
            // 
            출근부관리ToolStripMenuItem.Name = "출근부관리ToolStripMenuItem";
            출근부관리ToolStripMenuItem.Size = new Size(83, 20);
            출근부관리ToolStripMenuItem.Text = "출근부 관리";
            출근부관리ToolStripMenuItem.Click += 출근부관리ToolStripMenuItem_Click;
            // 
            // 사원등록ToolStripMenuItem
            // 
            사원등록ToolStripMenuItem.Name = "사원등록ToolStripMenuItem";
            사원등록ToolStripMenuItem.Size = new Size(67, 20);
            사원등록ToolStripMenuItem.Text = "사원등록";
            사원등록ToolStripMenuItem.Click += 사원등록ToolStripMenuItem_Click;
            // 
            // 사원관리ToolStripMenuItem
            // 
            사원관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 사원검색ToolStripMenuItem, 사원수정ToolStripMenuItem });
            사원관리ToolStripMenuItem.Name = "사원관리ToolStripMenuItem";
            사원관리ToolStripMenuItem.Size = new Size(71, 20);
            사원관리ToolStripMenuItem.Text = "사원 관리";
            // 
            // 사원검색ToolStripMenuItem
            // 
            사원검색ToolStripMenuItem.Name = "사원검색ToolStripMenuItem";
            사원검색ToolStripMenuItem.Size = new Size(155, 22);
            사원검색ToolStripMenuItem.Text = "사원 검색";
            사원검색ToolStripMenuItem.Click += 사원검색ToolStripMenuItem_Click;
            // 
            // 사원수정ToolStripMenuItem
            // 
            사원수정ToolStripMenuItem.Name = "사원수정ToolStripMenuItem";
            사원수정ToolStripMenuItem.Size = new Size(155, 22);
            사원수정ToolStripMenuItem.Text = "사원 수정/삭제";
            사원수정ToolStripMenuItem.Click += 사원수정ToolStripMenuItem_Click;
            // 
            // 부서관리ToolStripMenuItem
            // 
            부서관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 부서등록수정삭제ToolStripMenuItem1, 부서현황조회ToolStripMenuItem });
            부서관리ToolStripMenuItem.Name = "부서관리ToolStripMenuItem";
            부서관리ToolStripMenuItem.Size = new Size(71, 20);
            부서관리ToolStripMenuItem.Text = "부서 관리";
            // 
            // 부서등록수정삭제ToolStripMenuItem1
            // 
            부서등록수정삭제ToolStripMenuItem1.Name = "부서등록수정삭제ToolStripMenuItem1";
            부서등록수정삭제ToolStripMenuItem1.Size = new Size(184, 22);
            부서등록수정삭제ToolStripMenuItem1.Text = "부서 등록/수정/삭제";
            부서등록수정삭제ToolStripMenuItem1.Click += 부서등록수정삭제ToolStripMenuItem1_Click;
            // 
            // 부서현황조회ToolStripMenuItem
            // 
            부서현황조회ToolStripMenuItem.Name = "부서현황조회ToolStripMenuItem";
            부서현황조회ToolStripMenuItem.Size = new Size(184, 22);
            부서현황조회ToolStripMenuItem.Text = "부서 현황 조회";
            부서현황조회ToolStripMenuItem.Click += 부서현황조회ToolStripMenuItem_Click;
            // 
            // 급여관리ToolStripMenuItem
            // 
            급여관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 급여계산ToolStripMenuItem, 급여내역ToolStripMenuItem });
            급여관리ToolStripMenuItem.Name = "급여관리ToolStripMenuItem";
            급여관리ToolStripMenuItem.Size = new Size(71, 20);
            급여관리ToolStripMenuItem.Text = "급여 관리";
            // 
            // 인사조직ToolStripMenuItem
            // 
            인사조직ToolStripMenuItem.Name = "인사조직ToolStripMenuItem";
            인사조직ToolStripMenuItem.Size = new Size(79, 20);
            인사조직ToolStripMenuItem.Text = "인사조직도";
            인사조직ToolStripMenuItem.Click += 인사조직ToolStripMenuItem_Click;
            // 
            // 급여계산ToolStripMenuItem
            // 
            급여계산ToolStripMenuItem.Name = "급여계산ToolStripMenuItem";
            급여계산ToolStripMenuItem.Size = new Size(180, 22);
            급여계산ToolStripMenuItem.Text = "급여 계산";
            급여계산ToolStripMenuItem.Click += 급여계산ToolStripMenuItem_Click;
            // 
            // 급여내역ToolStripMenuItem
            // 
            급여내역ToolStripMenuItem.Name = "급여내역ToolStripMenuItem";
            급여내역ToolStripMenuItem.Size = new Size(180, 22);
            급여내역ToolStripMenuItem.Text = "급여 내역";
            급여내역ToolStripMenuItem.Click += 급여내역ToolStripMenuItem_Click;
            // 
            // FormPersonnel_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            Controls.Add(loadPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormPersonnel_Management";
            Text = "FormPersonnel_Management";
            Load += FormPersonnel_Management_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel loadPanel;
        private ToolStripMenuItem 출근부관리ToolStripMenuItem;
        private ToolStripMenuItem 부서관리ToolStripMenuItem;
        private ToolStripMenuItem 급여관리ToolStripMenuItem;
        public ToolStripMenuItem 사원등록ToolStripMenuItem;
        public ToolStripMenuItem 사원관리ToolStripMenuItem;
        public MenuStrip menuStrip;
        private ToolStripMenuItem 사원검색ToolStripMenuItem;
        private ToolStripMenuItem 사원수정ToolStripMenuItem;
        private ToolStripMenuItem 인사조직ToolStripMenuItem;
        private ToolStripMenuItem 부서현황조회ToolStripMenuItem;
        private ToolStripMenuItem 부서등록수정삭제ToolStripMenuItem1;
        private ToolStripMenuItem 급여계산ToolStripMenuItem;
        private ToolStripMenuItem 급여내역ToolStripMenuItem;
    }
}