using DBP_TeamProject.Forms.EmployeeManagement;
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
        public static FormPersonnel_Management pmForm;
        private EmployeeRegistration registPanel; // 사원 등록 패널

        private EmployeeManagement.EmployeeSearch employSearchPanel; // 사원관리 - 사원 검색 패널
        private EmployeeManagement.EmployeeModDel employeeModifyPanel; // 사원관리 - 사원 수정/삭제 패널

        private AttendanceManagement attendancePanel; // 출근부 관리 패널
        private DepartmentManagement departmentPanel; // 부서 관리 패널
        private SalaryStatement salaryPanel; // 급여 관리

        public FormPersonnel_Management()
        {
            InitializeComponent();
            InitPanels(); // 패널 초기화
            AddPanels(); // 패널 추가 
            HideAllPanels(); // 패널 안보이게
            pmForm = this;
        }
        private void InitPanels()
        {
            registPanel = new EmployeeRegistration();

            employSearchPanel = new EmployeeSearch();
            employeeModifyPanel = new EmployeeModDel();

            departmentPanel = new DepartmentManagement();
            attendancePanel = new AttendanceManagement();
            salaryPanel = new SalaryStatement();
        }
        private void AddPanels()
        {
            // 모든 패널 추가
            loadPanel.Controls.Add(registPanel);

            loadPanel.Controls.Add(employSearchPanel);
            loadPanel.Controls.Add(employeeModifyPanel);

            loadPanel.Controls.Add(departmentPanel);
            loadPanel.Controls.Add(attendancePanel);
            loadPanel.Controls.Add(salaryPanel);
        }
        private void HideAllPanels()
        {
            // 모든 패널을 숨김
            registPanel.Visible = false;
            employSearchPanel.Visible = false;
            employeeModifyPanel.Visible = false;
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
        private void 사원검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            employSearchPanel.Visible = true;
        }
        private void 사원수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            employeeModifyPanel.Visible = true;
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
