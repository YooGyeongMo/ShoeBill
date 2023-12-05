using DBP_TeamProject.Forms.Approval;
using System.Data;

namespace DBP_TeamProject.Forms
{
    public partial class FormApproval : Form
    {
        public FormApproval()
        {
            InitializeComponent();
        }

        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();
        LoginedUser loginedUser = LoginedUser.getInstance();

        NewApprove newApprove = new NewApprove();
        AdminApproveSearch adminApproveSearch = new AdminApproveSearch();



        public void tabControlSelected()
        {
            if (tabControlApproveData.SelectedIndex == 0)
            {
                buttonApproveAgree.Enabled = false;
                buttonApproveDisagree.Enabled = false;
                buttonApproveContinue.Enabled = true;
                buttonApproveDone.Enabled = true;
                buttonApproveSearch.Enabled = true;
            }
            else
            {
                buttonApproveAgree.Enabled = true;
                buttonApproveDisagree.Enabled = true;
                buttonApproveContinue.Enabled = false;
                buttonApproveDone.Enabled = false;
                buttonApproveSearch.Enabled = false;
            }
        }

        private void approveTotalSearch()
        {
            query.select("approveId as 결재아이디, userId as 기안자 , 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id")
                .where($"userId = {int.Parse(loginedUser.UserId)}");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();
            dataGridView1.DataSource = dt;
        }

        private void approveContinueDataSearch()
        {
            query.select("approveId as 결재아이디, userId as 기안자, 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id")
                .where($"userId = {int.Parse(loginedUser.UserId)} and approveStatus = 0");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();
            dataGridView1.DataSource = dt;
        }

        private void approveEndDataSearch()
        {
            query.select("approveId as 결재아이디, userId as 기안자, 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id")
                .where($"userId = {int.Parse(loginedUser.UserId)} and approveStatus = 1");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();
            dataGridView1.DataSource = dt;
        }

        private void approveListUpdate()
        {
            query.select("approveId as 결재아이디, userId as 기안자, 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id")
                .where($"currApprover = {int.Parse(loginedUser.UserId)} and approveStatus = 0");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();
            dataGridView2.DataSource = dt;
        }

        private void tabControlApproveData_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tabControlSelected();
            if (tabControlApproveData.SelectedIndex == 1)
            {
                approveListUpdate();
            }
        }

        private void setApproveInfo()
        { 
            newApprove.Title = textBoxTitle.Text;
            newApprove.Description = textBoxDescription.Text;

            newApprove.RelatedWork = comboBoxSubWork.Text;
            newApprove.setFirstApprover(comboBoxFirstDepartment.Text, textBoxFirstApprover.Text);
            newApprove.setLastApprover(comboBoxLastDepartment.Text, textBoxLastApprover.Text);

        }

        private void approveCreate()
        {
            string nullControlType = "";

            if (IsAnyTextBoxesEmpty(groupBoxApproveContent))
            {
                nullControlType = "결재 내용";
            }
            else if (IsAnyComboBoxesEmpty(groupBoxWork))
            {
                nullControlType = "관련 업무";
            }
            else if (IsAnyComboBoxesEmpty(groupBoxFirstApprover))
            {
                nullControlType = "중간 결재자";
            }
            else if (IsAnyComboBoxesEmpty(groupBoxLastApprover))
            {
                nullControlType = "최종 결재자";
            }
            else
            {
                setApproveInfo();
                int status = checkApprove();
                if (status == 0) return;
                newApprove.createApprove();
                return;
            }
            MessageBox.Show(nullControlType + "정보를 덜 입력하셨습니다.");
        }

        private int checkApprove()
        {
            int status = 1;
            if (newApprove.FirstApprover == newApprove.LastApprover)
            {
                MessageBox.Show("중간, 최종결재자가 같습니다\r\n다른 결재자를 선택해주세요!");
                status = 0;
            }

            if(newApprove.FirstApprover == int.Parse(loginedUser.UserId) || newApprove.LastApprover == int.Parse(loginedUser.UserId))
            {
                MessageBox.Show("기안자는 결재자가 될 수 없습니다!\r\n다른 결재자를 선택해주세요!");
                status = 0;
            }

            return status;
        }

        private void loadComboBox()
        {
            comboBoxLargeWork.Items.Clear();
            comboBoxFirstDepartment.Items.Clear();
            comboBoxLastDepartment.Items.Clear();
            textBoxFirstApprover.Clear();
            textBoxLastApprover.Clear();
            comboBoxMediumWork.Items.Clear();
            comboBoxSubWork.Items.Clear();
            textBoxTitle.Clear();
            textBoxDescription.Clear();
            comboBoxLargeWork.Items.AddRange(NewApprove.departments.ToArray());

            
            comboBoxFirstDepartment.Items.AddRange(NewApprove.departments.ToArray());
            comboBoxLastDepartment.Items.AddRange(NewApprove.departments.ToArray());
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

        private void FormApproval_Load(object sender, EventArgs e)
        {
            tabControlSelected();
            approveTotalSearch();
            newApprove.getDepartments();
            newApprove.getDeparmentMember();
            newApprove.getWorkCategory();
        }

        private void buttonApproveSearch_Click(object sender, EventArgs e)
        {
            approveTotalSearch();
        }

        private void buttonApproveContinue_Click(object sender, EventArgs e)
        {
            approveContinueDataSearch();
        }

        private void buttonApproveDone_Click(object sender, EventArgs e)
        {
            approveEndDataSearch();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void comboBoxLargeWork_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxMediumWork.Items.Clear();
            comboBoxMediumWork.Items.AddRange(newApprove.mediumCategoryLoad(comboBoxLargeWork.Text).ToArray());
        }

        private void comboBoxMediumWork_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxSubWork.Items.Clear();
            comboBoxSubWork.Items.AddRange(newApprove.subCategoryLoad(comboBoxLargeWork.Text, comboBoxMediumWork.Text).ToArray());
        }

        private void comboBoxFirstDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFirstApprover.Clear();
            textBoxFirstApprover.Text = newApprove.firstApproverLoad(comboBoxFirstDepartment.Text);
        }

        private void comboBoxLastDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxLastApprover.Clear();
            textBoxLastApprover.Text = newApprove.lastApproverLoad(comboBoxLastDepartment.Text);
            //comboBoxLastApprover.Items.AddRange(newApprove.lastApproverLoad(comboBoxLastDepartment.Text).ToArray());
        }

        private void ApproveCreateClick(object sender, EventArgs e)
        {

            approveCreate();
        }

        private void buttonApproveAgree_Click(object sender, EventArgs e)
        {
            // 아무것도 없을때 결재 진행 누르면 죽는거 해결하자

            try
            {
                if(dataGridView2.SelectedRows[0].Cells[1].Value == null)
                {
                    return;
                }
                int userId = int.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                if (userId == int.Parse(loginedUser.UserId))
                {
                    int approveId = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    string title = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                    string description = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();

                    FormApproveContinue formApproveContinue = new FormApproveContinue(approveId, title, description);
                    formApproveContinue.ShowDialog();
                }
                // 기안자가 내가 아닌 결재를 선택 후 결재 진행버튼을 눌렀을 때
                else
                {
                    string approveTime = DateTime.Now.ToString("g");
                    int approveId = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    string title = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();


                    query.insert("s5585452.Approver(approvalId, approver, approveTime, approveResult)")
                    .values($"({approveId}, {int.Parse(loginedUser.UserId)}, '{approveTime}', true)");

                    int status1 = dbManager.InitDBManager().ExecuteNonQueury(query.query);
                    dbManager.CloseConnection();
                    int status2 = updateCurrApprover(approveId);

                    if (status1 > 0 && status2 > 0)
                    {
                        MessageBox.Show("결재가 진행 되었습니다!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("선택된 결재가 없습니다!");
            }
            approveListUpdate();
        }
        private int updateCurrApprover(int approveId)
        {
            // 현재 결재자가 누구인지 또는 결재가 완료되었는지를 변경한다.

            int approveStatus = 1;

            query.select("userId, currApprover, firstApprover, secondApprover")
                .from("s5585452.Approval")
                .where($"approveId = {approveId}");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();

            int userId = int.Parse(dt.Rows[0][0].ToString());
            int firstApprover = int.Parse(dt.Rows[0][2].ToString());
            int lastApprover = int.Parse(dt.Rows[0][3].ToString());

            if (int.Parse(loginedUser.UserId) == firstApprover)
            {
                // 로그인한 유저가 중간결재자인 경우
                // currApprover를 최종 결재자로 변경한다.
                query.update("s5585452.Approval")
                    .set($"currApprover = {lastApprover}")
                    .where($"approveid = {approveId}");
            }
            else if (int.Parse(loginedUser.UserId) == lastApprover)
            {
                // 로그인한 유저가 최종결재자인 경우
                // approveStatus를 true로 바꾼다.
                query.update("s5585452.Approval")
                    .set($"approveStatus = {approveStatus}")
                    .where($"approveid = {approveId}");
            }
            else
            {
                // 로그인한 유저가 기안자인 경우
                // currApprover를 중간결재자로 변경한다.
                query.update("s5585452.Approval")
                    .set($"currApprover = {firstApprover}")
                    .where($"approveId = {approveId}");
            }

            int returnint = dbManager.InitDBManager().ExecuteNonQueury(query.query);
            dbManager.CloseConnection();
            return returnint;
        }

        private void buttonApproveDisagree_Click(object sender, EventArgs e)
        {
            // 아무것도 없을때 누르면 죽는거 해걸해야 함
            try
            {
                if (dataGridView2.SelectedRows[0].Cells[1].Value == null)
                {
                    return;
                }
                int userId = int.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                if (userId == int.Parse(loginedUser.UserId))
                {
                    MessageBox.Show("내가 등록한 결재는 반려가 불가능합니다.");
                    return;
                }
                int approveId = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                string title = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                string description = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                FormUnApprove formUnApprove = new FormUnApprove(approveId, title, description);
                formUnApprove.ShowDialog();
            }
            catch
            {
                MessageBox.Show("선택된 결재가 없습니다!");
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormUnApproveList formUnApproveList = new FormUnApproveList(int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
                formUnApproveList.ShowDialog();
            }
            catch { }
        }

        private void buttonAdminAllSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = adminApproveSearch.allApproveSearch();
            dataGridView3.DataSource = dt;
        }

        private void buttonAdminContinuingSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = adminApproveSearch.continuingApproveSearch();
            dataGridView3.DataSource = dt;
        }

        private void buttonAdminEndedSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = adminApproveSearch.endedApproveSearch();
            dataGridView3.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2 && !loginedUser.Level.Equals("관리자"))
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("사장만 사용할 수 있는 페이지입니다!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormApproveList formApproveList = new FormApproveList(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                formApproveList.ShowDialog();
            }
            catch { }
        }
    }
}
