namespace DBP_TeamProject.Forms
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
            menuStrip1 = new MenuStrip();
            사원등록ToolStripMenuItem = new ToolStripMenuItem();
            사원관리ToolStripMenuItem = new ToolStripMenuItem();
            출근부관리ToolStripMenuItem = new ToolStripMenuItem();
            부서관리ToolStripMenuItem = new ToolStripMenuItem();
            급여관리ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // loadPanel
            // 
            loadPanel.Location = new Point(0, 27);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(800, 420);
            loadPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 사원등록ToolStripMenuItem, 사원관리ToolStripMenuItem, 출근부관리ToolStripMenuItem, 부서관리ToolStripMenuItem, 급여관리ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
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
            사원관리ToolStripMenuItem.Name = "사원관리ToolStripMenuItem";
            사원관리ToolStripMenuItem.Size = new Size(71, 20);
            사원관리ToolStripMenuItem.Text = "사원 관리";
            사원관리ToolStripMenuItem.Click += 사원관리ToolStripMenuItem_Click;
            // 
            // 출근부관리ToolStripMenuItem
            // 
            출근부관리ToolStripMenuItem.Name = "출근부관리ToolStripMenuItem";
            출근부관리ToolStripMenuItem.Size = new Size(83, 20);
            출근부관리ToolStripMenuItem.Text = "출근부 관리";
            출근부관리ToolStripMenuItem.Click += 출근부관리ToolStripMenuItem_Click;
            // 
            // 부서관리ToolStripMenuItem
            // 
            부서관리ToolStripMenuItem.Name = "부서관리ToolStripMenuItem";
            부서관리ToolStripMenuItem.Size = new Size(71, 20);
            부서관리ToolStripMenuItem.Text = "부서 관리";
            부서관리ToolStripMenuItem.Click += 부서관리ToolStripMenuItem_Click;
            // 
            // 급여관리ToolStripMenuItem
            // 
            급여관리ToolStripMenuItem.Name = "급여관리ToolStripMenuItem";
            급여관리ToolStripMenuItem.Size = new Size(71, 20);
            급여관리ToolStripMenuItem.Text = "급여 관리";
            급여관리ToolStripMenuItem.Click += 급여관리ToolStripMenuItem_Click;
            // 
            // FormPersonnel_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(loadPanel);
            Margin = new Padding(2);
            Name = "FormPersonnel_Management";
            Text = "FormPersonnel_Management";
            Load += FormPersonnel_Management_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel loadPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 사원등록ToolStripMenuItem;
        private ToolStripMenuItem 사원관리ToolStripMenuItem;
        private ToolStripMenuItem 출근부관리ToolStripMenuItem;
        private ToolStripMenuItem 부서관리ToolStripMenuItem;
        private ToolStripMenuItem 급여관리ToolStripMenuItem;
    }
}