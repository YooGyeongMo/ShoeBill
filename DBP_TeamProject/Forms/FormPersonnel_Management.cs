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
        private Control currentControl;

        public static FormPersonnel_Management pmForm;
        private EmployeeRegistration registPanel; // 사원 등록 패널

        private EmployeeManagement.EmployeeSearch employSearchPanel; // 사원관리 - 사원 검색 패널
        private EmployeeManagement.EmployeeModDel employeeModifyPanel; // 사원관리 - 사원 수정/삭제 패널

        private AttendanceManagement attendancePanel; // 출근부 관리 패널
        private DepartmentManagement departmentPanel; // 부서관리 -부서 등록 수정 패널
        private DepartmentSearching departmentsearchingPanel;// 부서관리 - 부서 현황 패널

        private SalaryStatement salaryPanel; // 급여 관리

        private HumanResourcesOrganizationChart humanOrganizationChartPanel; // 인사 조직도
        public FormPersonnel_Management()
        {
            InitializeComponent();
            AddControls(); // 패널 추가 
            HideAllControls(); // 패널 안보이게
            pmForm = this;

            attendancePanel = new AttendanceManagement(); // 출근부 관리로 폼 시작
            ShowControl(attendancePanel);
        }
        private void AddControls()
        {
            // 모든 패널 추가
            loadPanel.Controls.Add(registPanel);

            loadPanel.Controls.Add(employSearchPanel);
            loadPanel.Controls.Add(employeeModifyPanel);

            loadPanel.Controls.Add(departmentPanel);
            loadPanel.Controls.Add(departmentsearchingPanel);

            loadPanel.Controls.Add(attendancePanel);
            loadPanel.Controls.Add(salaryPanel);

            loadPanel.Controls.Add(humanOrganizationChartPanel);
        }
        private void HideAllControls()
        {
            if (currentControl != null)
            {
                currentControl.Dispose(); // 이전 컨트롤 제거
                currentControl = null;
            }
        }
        private void ShowControl(Control control)
        {
            if (currentControl != control)
            {
                HideAllControls();
                currentControl = control;

                if (!loadPanel.Controls.Contains(currentControl))
                {
                    loadPanel.Controls.Add(currentControl);
                    currentControl.Dock = DockStyle.Fill;
                }
            }
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
        // [#1] 출근부 관리
        private void 출근부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            attendancePanel = new AttendanceManagement(); // 새로운 객체 생성
            ShowControl(attendancePanel);
        }
        // [#2] 사원 등록
        private void 사원등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            registPanel = new EmployeeRegistration(); // 새로운 객체 생성
            ShowControl(registPanel);
        }
        // [#3-1] 사원 관리 - 사원 검색
        private void 사원검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            employSearchPanel = new EmployeeSearch(); // 새로운 객체 생성
            ShowControl(employSearchPanel);
        }
        // [#3-2] 사원 관리 - 사원 수정/삭제
        private void 사원수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            employeeModifyPanel = new EmployeeModDel(); // 새로운 객체 생성
            ShowControl(employeeModifyPanel);
        }

        // [#4] 부서 관리 - 부서 등록/수정/삭제
        private void 부서등록수정삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideAllControls();
            departmentPanel = new DepartmentManagement(); // 새로운 객체 생성
            ShowControl(departmentPanel);
        }
        // [#4] 부서 관리 - 부서 현황 조회
        private void 부서현황조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            departmentsearchingPanel = new DepartmentSearching();
            ShowControl(departmentsearchingPanel);
        }

        // [#5] 급여 관리
        private void 급여관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            salaryPanel = new SalaryStatement(); // 새로운 객체 생성
            ShowControl(salaryPanel);
        }
        // [#6] 인사 조직도
        private void 인사조직ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            humanOrganizationChartPanel = new HumanResourcesOrganizationChart(); // 새로운 객체 생성
            ShowControl(humanOrganizationChartPanel);
        }

     

      
    }
}
