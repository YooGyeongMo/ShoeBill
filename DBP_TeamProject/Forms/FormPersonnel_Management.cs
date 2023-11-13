using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject.Forms
{
    public partial class FormPersonnel_Management : Form
    {
        private EmployeeRegistration registPanel;
        private EmployeeManagement employPanel;
        private DepartmentManagement departmentPanel;
        private AttendanceManagement attendancePanel;
        private SalaryStatement salaryPanel;

        public FormPersonnel_Management()
        {
            InitializeComponent();

            InitPanels(); // 패널 초기화
            AddPanels(); // 패널 추가 
            HideAllPanels(); // 패널 안보이게
        }
        private void InitPanels()
        {
            registPanel = new EmployeeRegistration();
            employPanel = new EmployeeManagement();
            departmentPanel = new DepartmentManagement();
            attendancePanel = new AttendanceManagement();
            salaryPanel = new SalaryStatement();
        }
        private void AddPanels()
        {
            // 모든 패널 추가
            loadPanel.Controls.Add(registPanel);
            loadPanel.Controls.Add(employPanel);
            loadPanel.Controls.Add(departmentPanel);
            loadPanel.Controls.Add(attendancePanel);
            loadPanel.Controls.Add(salaryPanel);
        }
        private void HideAllPanels()
        {
            // 모든 패널을 숨김
            registPanel.Visible = false;
            employPanel.Visible = false;
            departmentPanel.Visible = false;
            attendancePanel.Visible = false;
            salaryPanel.Visible = false;
        }
        private void FormPersonnel_Management_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void 사원등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            registPanel.Visible = true;
        }

        private void 사원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            employPanel.Visible = true;
        }

        private void 출근부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            attendancePanel.Visible = true;
        }

        private void 부서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            departmentPanel.Visible = true;
        }

        private void 급여관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            salaryPanel.Visible = true;
        }
    }
}
