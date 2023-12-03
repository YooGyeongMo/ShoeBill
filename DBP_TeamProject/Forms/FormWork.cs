using DBP_TeamProject.Forms.WorkMaster;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DBP_TeamProject.Forms
{
    public partial class FormWork : Form
    {

        private class DataItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }


        private LoginedUser loginedUser;


        public FormWork()
        {
            InitializeComponent();

            // 폼 로드 시 테이블 데이터를 ComboBox에 표시
            LoadExistingData(comboBox_bigcategory, "대분류ID", "대분류명", "분류_대분류");
        }

        private void LoadExistingData(ComboBox comboBox, string idColumnName, string nameColumnName, string tableName)
        {
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {idColumnName}, {nameColumnName} FROM s5585452.{tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem menuItem = new DataItem
                            {
                                ID = Convert.ToInt32(reader[idColumnName]),
                                Name = Convert.ToString(reader[nameColumnName])
                            };

                            comboBox.Items.Add(menuItem);
                        }
                    }
                }
            }

            comboBox.SelectedIndex = -1;
        }

        private void 일일업무검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkSearcher WorksearcherForm = new WorkSearcher();
            WorksearcherForm.Show();
        }


        private void 일일업무수정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (LoginedUser.getInstance().Level != "관리자") // 관리자 이외 접근 불가
            {
                MessageBox.Show("관리자만 접근할 수 있습니다.");
                return;
            }
            WorkUpdater WorkupdaterForm = new WorkUpdater();
            WorkupdaterForm.Show();
        }

        private void 일일업무삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (LoginedUser.getInstance().Level != "관리자") // 관리자 이외 접근 불가
            {
                MessageBox.Show("관리자만 접근할 수 있습니다.");
                return;
            }
            WorkDeleter WorkdeleterForm = new WorkDeleter();
            WorkdeleterForm.Show();
        }


        private void 업무마스터등록toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginedUser.getInstance().Level != "관리자") // 관리자 이외 접근 불가
            {
                MessageBox.Show("관리자만 접근할 수 있습니다.");
                return;
            }
            MasterMaker MastermakerForm = new MasterMaker();
            MastermakerForm.Show();

        }

        private void 업무마스터수정toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginedUser.getInstance().Level != "관리자") // 관리자 이외 접근 불가
            {
                MessageBox.Show("관리자만 접근할 수 있습니다.");
                return;
            }
            MasterUpdater MasterupdaterForm = new MasterUpdater();
            MasterupdaterForm.Show();
        }

        private void 업무마스터삭제toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginedUser.getInstance().Level != "관리자") // 관리자 이외 접근 불가
            {
                MessageBox.Show("관리자만 접근할 수 있습니다.");
                return;
            }
            MasterDeleter MasterdeleterForm = new MasterDeleter();
            MasterdeleterForm.Show();
        }
        private bool IsAnyTextBoxesEmpty(GroupBox groupBox)
        {
            // 그룹박스 안에 있는 모든 텍스트 박스
            var textBoxes = groupBox.Controls.OfType<TextBox>();

            // 텍스트 박스가 하나라도 비어있으면
            return textBoxes.Any(textBox => string.IsNullOrEmpty(textBox.Text));
        }
        private bool IsAnyComboBoxesEmpty(GroupBox groupBox)
        {
            // 그룹박스 안에 있는 모든 콤보박스
            var comboBoxes = groupBox.Controls.OfType<ComboBox>();

            // 콤보박스가 하나라도 선택된 항목이 없으면
            return comboBoxes.Any(comboBox => comboBox.SelectedIndex == -1);
        }

        private void button_work_Click(object sender, EventArgs e)
        {
            if (IsAnyComboBoxesEmpty(workRegistrationGroupBox))
            {
                MessageBox.Show("입력사항을 모두 선택해주세요");
                return;
            }
            if (IsAnyTextBoxesEmpty(workRegistrationGroupBox))
            {
                MessageBox.Show("비고란을 입력해주세요.");
                return;
            }

            string bigCategory = comboBox_bigcategory.Text;
            if (!bigCategory.Equals(LoginedUser.getInstance().Department)) // 본인 부서이면
            {
                MessageBox.Show(bigCategory);
                MessageBox.Show(LoginedUser.getInstance().Department);
                MessageBox.Show("본인 부서만 업무 등록할 수 있습니다.");
                return;
            }

            string midCategory = comboBox_midcategory.Text;
            string smallCategory = comboBox_smallcategory.Text;
            string memo = textBox_memo.Text;

            int stime = Convert.ToInt32(comboBox_stime.SelectedItem);
            int smin = Convert.ToInt32(comboBox_smin.SelectedItem);

            TimeSpan startTime = new TimeSpan(stime, smin, 00);

            int etime = Convert.ToInt32(comboBox_etime.SelectedItem);
            int emin = Convert.ToInt32(comboBox_emin.SelectedItem);

            TimeSpan endTime = new TimeSpan(etime, emin, 00);

            if (startTime >= endTime)
            {
                MessageBox.Show("업무 시작 시간이 업무 종료 시간보다 뒤에 있습니다. 올바른 시간을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(bigCategory) || string.IsNullOrWhiteSpace(midCategory) ||
                string.IsNullOrWhiteSpace(smallCategory) || string.IsNullOrWhiteSpace(memo) ||
                 (stime == null && smin == null) || (etime == null && emin == null))
            {
                MessageBox.Show("모든 항목를 선택해야 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string useId = LoginedUser.getInstance().UserId;
            //int userId = loginForm.loginedUser.UserId; // 업무등록자 정보

            string userId = LoginedUser.getInstance().UserId;

            // 새로운 업무의 시작 시간과 종료 시간
            TimeSpan newStartTime = startTime;
            TimeSpan newEndTime = endTime;

            // 기존 업무와 겹치는지 확인
            if (IsWorkPeriodOverlap(userId, newStartTime, newEndTime))
            {
                MessageBox.Show("이미 등록된 기간과 업무 시간이 겹칩니다. 다른 시간을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 겹치면 등록 중단
            }


            // MySQL 연결 문자열
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;"; // 연결 문자열을 실제 MySQL 서버 정보로 변경

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // SQL 쿼리 작성 
                string query = "INSERT INTO s5585452.일일업무 (대분류명, 중분류명, 소분류명, 업무등록자, 업무시작시간, 업무종료시간, 비고, 업무등록일자) " +
                    "VALUES (@대분류명, @중분류명, @소분류명, @업무등록자, @업무시작시간, @업무종료시간, @비고, @업무등록일자)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // 매개변수 추가
                    command.Parameters.AddWithValue("@대분류명", bigCategory);
                    command.Parameters.AddWithValue("@중분류명", midCategory);
                    command.Parameters.AddWithValue("@소분류명", smallCategory);
                    command.Parameters.AddWithValue("@업무등록자", useId);
                    command.Parameters.AddWithValue("@업무시작시간", startTime);
                    command.Parameters.AddWithValue("@업무종료시간", endTime);
                    command.Parameters.AddWithValue("@비고", memo);
                    command.Parameters.AddWithValue("@업무등록일자", DateTime.Now);
                    // 쿼리 실행
                    command.ExecuteNonQuery();

                    MessageBox.Show("일일업무가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // 업무 등록 후 텍스트박스와 콤보박스 비우기
            comboBox_bigcategory.SelectedIndex = -1;
            comboBox_midcategory.SelectedIndex = -1;
            comboBox_smallcategory.SelectedIndex = -1;
            textBox_memo.Text = "";
            comboBox_stime.SelectedIndex = -1;
            comboBox_smin.SelectedIndex = -1;
            comboBox_etime.SelectedIndex = -1;
            comboBox_emin.SelectedIndex = -1;
        }

        private bool IsWorkPeriodOverlap(string userId, TimeSpan newStartTime, TimeSpan newEndTime)
        {
            // MySQL 연결 문자열
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 기존 업무 기간 및 업무등록자 조회 쿼리 작성
                string query = Query.GetInstance().
                            select("업무시작시간, 업무종료시간").
                            from("일일업무").
                            where($"업무등록자 = '{userId}' AND 업무등록일자=CURDATE()").
                            exec();



                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 기존 업무의 시작 시간과 종료 시간
                            TimeSpan existingStartTime = ((TimeSpan)reader["업무시작시간"]);
                            TimeSpan existingEndTime = ((TimeSpan)reader["업무종료시간"]);

                            MessageBox.Show(existingStartTime.ToString());
                            MessageBox.Show(existingEndTime.ToString());

                            // 새로운 업무와 겹치는지 확인
                            if (IsTimeOverlap(newStartTime, newEndTime, existingStartTime, existingEndTime))
                            {
                                return true; // 겹친다면 true 반환
                            }
                        }
                    }
                }
            }

            return false; // 겹치는 업무가 없다면 false 반환
        }

        // 두 기간이 겹치는지 확인하는 메서드
        private bool IsTimeOverlap(TimeSpan startTime1, TimeSpan endTime1, TimeSpan startTime2, TimeSpan endTime2)
        {
            return startTime1 < endTime2 && startTime2 < endTime1;
        }

        // [#1] 대분류
        private void comboBox_bigcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_midcategory.SelectedIndex = -1;
            comboBox_smallcategory.SelectedIndex = -1;

            // 선택된 대분류가 없으면 종료
            if (comboBox_bigcategory.SelectedItem == null)
            {
                return;
            }

            string bigCategory = comboBox_bigcategory.SelectedItem.ToString();
            int selectedBigCategoryID = GetBigID(bigCategory);

            // 선택된 대분류의 ID를 가져옴
            //int selectedBigCategoryID = ((DataItem)comboBox_bigcategory.SelectedItem).ID;

            LoadMidCategories(selectedBigCategoryID);
        }
        private void comboBox_midcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_smallcategory.SelectedIndex = -1;

            // 선택된 대분류가 없으면 종료
            if (comboBox_midcategory.SelectedItem == null)
            {
                return;
            }
            string midCategory = comboBox_midcategory.SelectedItem.ToString();
            int selectedMidCategoryID = GetMidID(midCategory);

            // 소분류를 로드  
            comboBox_smallcategory.Items.Clear();
            LoadSmallCategories(selectedMidCategoryID);
        }

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
        private void LoadMidCategories(int bigCategoryId)
        {
            // MySQL 연결 문자열
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;"; // 연결 문자열을 실제 MySQL 서버 정보로 변경

            // 기존 중분류 항목을 지우고 다시 로드
            comboBox_midcategory.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 선택된 대분류에 해당하는 중분류 로드 쿼리 작성
                string query = "SELECT 중분류ID, 중분류명 FROM s5585452.분류_중분류 WHERE 대분류ID = @대분류ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@대분류ID", bigCategoryId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem menuItem = new DataItem
                            {
                                ID = Convert.ToInt32(reader["중분류ID"]),
                                Name = Convert.ToString(reader["중분류명"])
                            };

                            comboBox_midcategory.Items.Add(menuItem);
                            // 선택된 아이템이 없도록 설정
                            comboBox_midcategory.SelectedIndex = -1;
                        }
                    }
                }
            }

            // 선택된 아이템이 없도록 설정
            //   comboBox_midcategory.SelectedIndex = -1;
        }



        private void LoadSmallCategories(int midCategoryId)
        {
            // MySQL 연결 문자열
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;"; // 연결 문자열을 실제 MySQL 서버 정보로 변경

            // 기존 소분류 항목을 지우고 다시 로드
            comboBox_smallcategory.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 선택된 중분류에 해당하는 소분류 로드 쿼리 작성
                string query = "SELECT 소분류ID, 소분류명 FROM s5585452.분류_소분류 WHERE 중분류ID = @중분류ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@중분류ID", midCategoryId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataItem menuItem = new DataItem
                            {
                                ID = Convert.ToInt32(reader["소분류ID"]),
                                Name = Convert.ToString(reader["소분류명"])
                            };

                            comboBox_smallcategory.Items.Add(menuItem);
                            // 선택된 아이템이 없도록 설정
                            comboBox_smallcategory.SelectedIndex = -1;
                        }
                    }
                }
            }


        }




        // 중복 없이 부서이름들을 가져오는 메서드
        private List<string> GetDistinctDepartmentNames()
        {
            List<string> departmentNames = new List<string>();

            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT 부서이름 FROM 부서";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string departmentName = reader["부서이름"].ToString();
                            departmentNames.Add(departmentName);
                        }
                    }
                }
            }

            return departmentNames;
        }



        // 테이블에서 사용 중인 가장 큰 ID에 1을 더하여 가져오는 메서드
        private int GetNextCategoryId(string tableName, string idColumnName)
        {
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT IFNULL(MAX({idColumnName}), 0) + 1 FROM s5585452.{tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        // 테이블에 데이터가 이미 존재하는지 확인하는 메서드
        private bool IsDepartmentExists(string tableName, string columnName, string value)
        {
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM s5585452.{tableName} WHERE {columnName} = @Value";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        // 테이블에 데이터를 삽입하는 메서드
        private void InsertDepartment(string tableName, string idColumnName, string nameColumnName, int idValue, string nameValue)
        {
            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO s5585452.{tableName} ({idColumnName}, {nameColumnName}) VALUES (@ID, @Name)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", idValue);
                    command.Parameters.AddWithValue("@Name", nameValue);
                    command.ExecuteNonQuery();
                }
            }
        }
        // [#1-0] 대분류 콤보박스 드롭다운
        private void comboBox_bigcategory_DropDown(object sender, EventArgs e)
        {
            comboBox_bigcategory.Items.Clear(); // 콤보박스 내용 초기화
            string query = Query.GetInstance().
                            select("부서이름").
                            from("부서").
                            exec();
            Category.GetInstance().LoadComboBoxData(comboBox_bigcategory, query, "부서이름");
        }

        // [#1-1] 중분류 콤보박스 드롭다운
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
        // [#1-2] 소분류 콤보박스 드롭다운
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
            string bigcategoryName = comboBox_bigcategory.Text;
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

        private void FormWork_Load(object sender, EventArgs e)
        {
            // 로그인한 사용자의 부서 이름 가져오기
            string userDepartment = LoginedUser.getInstance().Department;

            // 부서 테이블에서 중복 없이 부서이름들을 가져오기
            List<string> departmentNames = GetDistinctDepartmentNamesFromEmployee();

            // 대분류 테이블에 순차적으로 삽입
            foreach (string departmentName in departmentNames)
            {
                // 대분류가 이미 존재하는지 확인
                if (!IsDepartmentExists("분류_대분류", "대분류명", departmentName))
                {
                    // 대분류ID를 현재 테이블에서 사용 중인 가장 큰 값에 1을 더하여 가져오기
                    int nextBigCategoryId = GetNextCategoryId("분류_대분류", "대분류ID");

                    // 대분류를 삽입
                    InsertDepartment("분류_대분류", "대분류ID", "대분류명", nextBigCategoryId, departmentName);
                }
            }

            // 콤보박스 다시 로드
            comboBox_bigcategory.SelectedIndex = -1;
            comboBox_bigcategory.Items.Clear();
            LoadExistingData(comboBox_bigcategory, "대분류ID", "대분류명", "분류_대분류");

            // 폼이 로드될 때 로그인한 유저의 부서 이름으로 대분류 콤보박스를 초기화하고 선택되도록 함
            if (comboBox_bigcategory.Items.OfType<DataItem>().Any(item => item.Name.Equals(userDepartment, StringComparison.OrdinalIgnoreCase)))
            {
                comboBox_bigcategory.SelectedItem = comboBox_bigcategory.Items.OfType<DataItem>().First(item => item.Name.Equals(userDepartment, StringComparison.OrdinalIgnoreCase));
                comboBox_bigcategory.Enabled = false; // 사용자가 변경하지 못하도록 비활성화
            }
            else
            {
                MessageBox.Show("로그인한 유저의 부서가 대분류 목록에 없습니다.");
            }
        }

        private List<string> GetDistinctDepartmentNamesFromEmployee()
        {
            List<string> departmentNames = new List<string>();

            string connectionString = "Server=115.85.181.212;Database=s5585452;User ID=s5585452;Password=s5585452; charset=utf8;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT 부서이름 FROM 사원";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string departmentName = reader["부서이름"].ToString();
                            departmentNames.Add(departmentName);
                        }
                    }
                }
            }

            return departmentNames;
        }
    }
}

