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
    public partial class HumanResourcesOrganizationChart : UserControl
    {
        List<string> departmentNames = new List<string>();
        List<string> employeeNames = new List<string>();
        public HumanResourcesOrganizationChart()
        {
            InitializeComponent();
            InitTreeview();
        }
        public void InitTreeview()
        {
            // 최상위 노드 (루트)
            TreeNode rootNode = new TreeNode("사장");

            GetDepartmentNames(); // 부서 이름 리스트
            // 부서 이름 리스트에서 각 부서를 트리에 추가
            foreach (string departmentName in departmentNames)
            {
                TreeNode departmentNode = new TreeNode(departmentName);

                // MySQL에서 해당 부서의 사원 목록 가져오기
                GetEmployeesByDepartment(departmentName);
                foreach (string employeeName in employeeNames)
                {
                    TreeNode employeeNode = new TreeNode(employeeName);
                    departmentNode.Nodes.Add(employeeNode);
                }

                rootNode.Nodes.Add(departmentNode);
            }

            // 트리뷰에 최상위 노드 추가
            HumanResourcesTreeView.Nodes.Add(rootNode);
        }

        // DB에서 부서이름 받아오기
        public void GetDepartmentNames()
        {
            string query = Query.GetInstance().
                            select("부서이름").
                            from("부서").
                            exec();
            departmentNames = DBManager.GetInstance().InitDBManager().GetList(query, "부서이름");
            DBManager.GetInstance().CloseConnection();
        }
        public void GetEmployeesByDepartment(string departmentName)
        {
            string query = Query.GetInstance().
                            select("이름").
                            from("사원").
                            where($"부서이름='{departmentName}'").
                            exec();
            employeeNames = DBManager.GetInstance().InitDBManager().GetList(query, "이름");
            DBManager.GetInstance().CloseConnection();
        }
    }
}
