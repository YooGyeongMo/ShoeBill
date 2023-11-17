using GookBabProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject.Forms.EmployeeManagement
{
    public partial class EmployeeSearch : UserControl
    {
        private string department;
        private string name;
        private string age;


        public EmployeeSearch()
        {
            InitializeComponent();
        }
        private bool IsAnyComboBoxesEmpty(GroupBox groupBox) // 그룹 박스 안 콤보박스 비어있는
        {
            // 그룹박스 안에 있는 모든 콤보박스
            var comboBoxes = groupBox.Controls.OfType<ComboBox>();

            // 콤보박스가 하나라도 선택된 항목이 없으면
            return comboBoxes.Any(comboBox => comboBox.SelectedIndex == -1);
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (IsAnyComboBoxesEmpty(searchGroupBox)) // 부서선택 콤보박스가 비어있으면
            {
                errorMsgLabel.Text = "부서를 선택해주세요";
                errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                department = departmentComboBox.SelectedItem.ToString();
                name = nameTextBox.Text;
                age = ageTextBox.Text;

                string query = Query.GetInstance().
                    select("b.부서이름, b.부서장, s.이름, TIMESTAMPDIFF(YEAR, s.생년월일, CURDATE()) AS 나이, s.직급, s.우편번호, s.주소 "). // 나이 출력
                    from("부서 b").
                    innerJoin("사원 s ON b.부서이름 = s.부서이름").
                    where($"b.부서이름='{department}' " +
                    $"AND (s.이름='{name}' OR '{name}'='')" +
                    $"AND (TIMESTAMPDIFF(YEAR, 생년월일, CURDATE()) = '{age}' OR '{age}' = '')"). // 나이 비교
                    exec();

                DataTable dataTable = DBManager.GetInstance().InitDBManager().FindDataTable(query);

                memberdataGridView.DataSource = dataTable;
                memberdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBManager.GetInstance().CloseConnection();
            }
        }


    }
}
