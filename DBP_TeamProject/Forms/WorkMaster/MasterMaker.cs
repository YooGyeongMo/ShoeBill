using DBP_TeamProject.Forms.WorkMaster;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DBP_TeamProject.Forms
{

    public partial class MasterMaker : Form
    {
        public MasterMaker()
        {
            InitializeComponent();
        }
        // [#1] 대분류 콤보박스 드롭다운
        private void comboBox_bigcategory_DropDown(object sender, EventArgs e)
        {
            comboBox_bigcategory.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                            select("부서이름").
                            from("부서").
                            exec();
            Category.GetInstance().LoadComboBoxData(comboBox_bigcategory,query, "부서이름");
        }
        // [#2] 중분류 콤보박스 드롭다운
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
        // [#1-0] 중분류 추가 버튼 클릭
        private void button_addmid_Click(object sender, EventArgs e)
        {
            string inputData = textBox_mid.Text; // 중분류 입력

            if (comboBox_bigcategory.SelectedIndex == -1)
            {
                MessageBox.Show("대분류를 선택해주세요.");
                return;
            }
            if (inputData == "")
            {
                MessageBox.Show("중분류를 입력해주세요.");
                return;
            }
            string bigcategoryName = comboBox_bigcategory.SelectedItem.ToString();
            int selectedBigCategoryID = GetBigID(bigcategoryName);

            if (IsDuplicateMidCategoryTable(selectedBigCategoryID, inputData)) // 중분류 테이블 중복 검사
            {
                MessageBox.Show("중복되는 업무가 등록되어 있습니다.");
                return;
            }
            try
            {
                string query = Query.GetInstance().
                                insert("분류_중분류 (중분류명,대분류ID)").
                                values($"('{inputData}','{selectedBigCategoryID}')").
                                exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
                MessageBox.Show("중분류가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // 텍스트박스 초기화
            textBox_mid.Text = "";
        }
        // [#1-1] 중분류 테이블 중복 검사
        public bool IsDuplicateMidCategoryTable(int selectedBigCategoryID, string selectedMidCategoryName)
        {
            bool isDuplicate = false;
            try
            {
                string query = Query.GetInstance()
                        .select("COUNT(*)")
                        .from("분류_중분류")
                        .where($"대분류ID={selectedBigCategoryID} AND 중분류명='{selectedMidCategoryName}'")
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
        // [#1-2] 대분류 ID 받아오기
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
        // [#2-0] 소분류 추가 버튼 클릭
        private void button_addsmall_Click(object sender, EventArgs e)
        {
            string inputData = textBox_small.Text; // 소분류 입력
            if (comboBox_midcategory.SelectedIndex == -1)
            {
                MessageBox.Show("중분류를 선택해주세요.");
                return;
            }
            if (inputData == "")
            {
                MessageBox.Show("소분류를 입력해주세요.");
                return;
            }
            string midcategoryName = comboBox_midcategory.SelectedItem.ToString();
            int selectedMidCategoryID = GetMidID(midcategoryName);

            if (IsDuplicateSmallCategoryTable(selectedMidCategoryID, inputData)) // 중분류 테이블 중복 검사
            {
                MessageBox.Show("중복되는 업무가 등록되어 있습니다.");
                return;
            }
            try
            {
                string query = Query.GetInstance().
                                insert("분류_소분류 (소분류명,중분류ID)").
                                values($"('{inputData}','{selectedMidCategoryID}')").
                                exec();
                DBManager.GetInstance().InitDBManager().ExecuteNonQueury(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.ToString());
            }
            finally
            {
                DBManager.GetInstance().CloseConnection();
            }
            MessageBox.Show("소분류가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBox_bigcategory.SelectedIndex = -1;
            comboBox_bigcategory.Items.Clear();

            comboBox_midcategory.SelectedIndex = -1;
            comboBox_midcategory.Items.Clear();

            // 텍스트박스 초기화
            textBox_small.Text = "";
        }
        // [#2-1] 중분류 테이블 중복 검사
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

        // [#2-2] 중분류 ID 받아오기
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

        private void comboBox_bigcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_midcategory.SelectedIndex = -1;
            comboBox_midcategory.Items.Clear();
        }
    }
}