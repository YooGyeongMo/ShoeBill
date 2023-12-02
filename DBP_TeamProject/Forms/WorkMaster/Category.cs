using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_TeamProject.Forms.WorkMaster
{
    internal class Category
    {
        public static Category instance = new Category();
        public static Category GetInstance()
        {
            return instance;
        }

        // DB에서 분류명에 따른 결과 콤보박스 밀어넣기
        public void LoadComboBoxData(ComboBox comboBox, string query, string columnName)
        {
            List<string> departmentNames = new List<string>();

            comboBox.Items.Clear(); // 콤보박스 내용 초기화
            try
            {
                departmentNames = DBManager.GetInstance().InitDBManager().GetList(query, columnName);
                DBManager.GetInstance().CloseConnection();

                comboBox.Items.AddRange(departmentNames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
        }
    }

}
