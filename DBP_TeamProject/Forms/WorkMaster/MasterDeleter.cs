using DBP_TeamProject.Forms.WorkMaster;
using MySql.Data.MySqlClient;

namespace DBP_TeamProject.Forms
{
    public partial class MasterDeleter : Form
    {
        public MasterDeleter()
        {
            InitializeComponent();
        }
        // [#1-0] 대분류 드롭다운 
        private void comboBox_bigcategory_DropDown(object sender, EventArgs e)
        {
            comboBox_bigcategory.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                            select("부서이름").
                            from("부서").
                            exec();
            Category.GetInstance().LoadComboBoxData(comboBox_bigcategory, query, "부서이름");
        }

        // [#1-1] 중분류 드롭다운 
        private void comboBox_midcategory_DropDown(object sender, EventArgs e)
        {
            if (comboBox_bigcategory.SelectedIndex == -1)
            {
                MessageBox.Show("대분류를 선택해주세요.");
                return;
            }
            string bigcategoryName = comboBox_bigcategory.SelectedItem.ToString();

            comboBox_midcategory.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                            select("중분류명").
                            from("분류_중분류").
                            where($"대분류ID IN (SELECT 대분류ID FROM 분류_대분류 WHERE 대분류명 = '{bigcategoryName}')").
                            exec();

            Category.GetInstance().LoadComboBoxData(comboBox_midcategory, query, "중분류명");
        }
        // [#1-1] 소분류 드롭다운 

        private void comboBox_smallcategory_DropDown(object sender, EventArgs e)
        {
            if (comboBox_bigcategory.SelectedIndex == -1)
            {
                MessageBox.Show("대분류를 선택해주세요.");
                return;
            }
            if (comboBox_midcategory.SelectedIndex == -1)
            {
                MessageBox.Show("중분류를 선택해주세요.");
                return;
            }
            string bigcategoryName = comboBox_bigcategory.SelectedItem.ToString();
            int selectedBigCategoryID = GetBigID(bigcategoryName);

            string midcategoryName = comboBox_midcategory.SelectedItem.ToString();

            comboBox_smallcategory.Items.Clear();
            string query = Query.GetInstance().
                            select("소분류명").
                            from("분류_소분류").
                            where($"중분류ID IN (SELECT 중분류ID FROM 분류_중분류 WHERE 대분류ID={selectedBigCategoryID} AND 중분류명='{midcategoryName}')").
                            exec();
            Category.GetInstance().LoadComboBoxData(comboBox_smallcategory, query, "소분류명");
        }
        // [#1-4] 대분류 ID 받아오기
        public int GetBigID(string bigCategory)
        {
            int result = 0;
            try
            {
                string query = Query.GetInstance()
                        .select("대분류ID")
                        .from("분류_대분류")
                        .where($"대분류명='{bigCategory}'")
                        .exec();

                result = Int32.Parse(DBManager.GetInstance().InitDBManager().GetInfo(query));
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            return result;
        }
        private void comboBox_bigcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_midcategory.SelectedIndex = -1;
            comboBox_midcategory.Items.Clear();

            comboBox_smallcategory.SelectedIndex = -1;
            comboBox_smallcategory.Items.Clear();
        }

        private void comboBox_midcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_smallcategory.SelectedIndex = -1;
            comboBox_smallcategory.Items.Clear();
        }

        // [#2] 중분류 삭제 
        private void button_deletemid_Click(object sender, EventArgs e)
        {
            if (comboBox_bigcategory.SelectedIndex == -1)
            {
                MessageBox.Show("대분류를 선택해주세요.");
                return;
            }
            if (comboBox_midcategory.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 중분류를 선택해주세요.");
                return;
            }
            string bigcategoryName = comboBox_bigcategory.SelectedItem.ToString(); // 대분류
            string midcategoryName = comboBox_midcategory.SelectedItem.ToString(); // 중분류

            int selectedBigCategoryID = GetBigID(bigcategoryName);

            if (!IsDuplicateMidCategoryTable(selectedBigCategoryID, midcategoryName)) // 중분류 테이블 중복되지 않으면
            {
                MessageBox.Show("해당 업무 분류가 존재하지 않습니다.");
                return;
            }
            try
            {
                string query = Query.GetInstance().
                                deleteFrom("분류_중분류").
                                where($"대분류ID = '{selectedBigCategoryID}' AND 중분류명='{midcategoryName}'").
                                exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                MessageBox.Show("중분류가 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }

            comboBox_bigcategory.SelectedIndex = -1;
            comboBox_bigcategory.Items.Clear();

            comboBox_midcategory.SelectedIndex = -1;
            comboBox_midcategory.Items.Clear();

            comboBox_smallcategory.SelectedIndex = -1;
            comboBox_smallcategory.Items.Clear();
        }
        // [#2-1] 중분류 테이블 중복 검사
        public bool IsDuplicateMidCategoryTable(int selectedBigCategoryID, string midcategoryName)
        {
            bool isDuplicate = false;
            try
            {
                string query = Query.GetInstance()
                        .select("COUNT(*)")
                        .from("분류_중분류")
                        .where($"대분류ID={selectedBigCategoryID} AND 중분류명='{midcategoryName}'")
                        .exec();

                isDuplicate = DBManager.GetInstance().InitDBManager().GetId(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            return isDuplicate;
        }

        // [#3] 소분류 삭제 버튼 클릭
        private void button_deletesmall_Click(object sender, EventArgs e)
        {
            if (comboBox_bigcategory.SelectedIndex == -1)
            {
                MessageBox.Show("대분류를 선택해주세요.");
                return;
            }
            if (comboBox_midcategory.SelectedIndex == -1)
            {
                MessageBox.Show("중분류를 선택해주세요.");
                return;
            }
            if (comboBox_smallcategory.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 소분류를 선택해주세요.");
                return;
            }

            string midcategoryName = comboBox_midcategory.SelectedItem.ToString(); // 중분류
            string smallcategoryName = comboBox_smallcategory.SelectedItem.ToString(); // 소분류

            int selectedMidCategoryID = GetMidID(midcategoryName);
            if (!IsDuplicateSmallCategoryTable(selectedMidCategoryID, smallcategoryName))
            {
                MessageBox.Show("해당 업무 분류가 존재하지 않습니다.");
                return;
            }
            try
            {
                string query = Query.GetInstance().
                                deleteFrom("분류_소분류").
                                where($"중분류ID = {selectedMidCategoryID} AND 소분류명='{smallcategoryName}'").
                                exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                MessageBox.Show("소분류가 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }

            comboBox_bigcategory.SelectedIndex = -1;
            comboBox_bigcategory.Items.Clear();

            comboBox_midcategory.SelectedIndex = -1;
            comboBox_midcategory.Items.Clear();

            comboBox_smallcategory.SelectedIndex = -1;
            comboBox_smallcategory.Items.Clear();
        }
        // [#3-1] 중분류 ID 받아오기
        public int GetMidID(string midCategory)
        {
            int result = 0;
            try
            {
                string query = Query.GetInstance()
                        .select("중분류ID")
                        .from("분류_중분류")
                        .where($"중분류명='{midCategory}'")
                        .exec();

                result = Int32.Parse(DBManager.GetInstance().InitDBManager().GetInfo(query));
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            return result;
        }
        // [#3-2] 소분류 테이블 중복 검사
        public bool IsDuplicateSmallCategoryTable(int selectedMidCategoryID, string selectedSmallCategoryName)
        {
            bool isDuplicate = false;
            try
            {
                string query = Query.GetInstance()
                        .select("COUNT(*)")
                        .from("분류_소분류")
                        .where($"중분류ID={selectedMidCategoryID} AND 소분류명='{selectedSmallCategoryName}'")
                        .exec();

                isDuplicate = DBManager.GetInstance().InitDBManager().GetId(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            return isDuplicate;
        }
    }
}
