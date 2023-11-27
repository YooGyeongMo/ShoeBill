using System.Data;

namespace DBP_TeamProject.Forms.Approval
{
    public partial class FormUnApprove : Form
    {
        public FormUnApprove(int approveId, string title, string describe)
        {
            InitializeComponent();
            this.approveId = approveId;
            this.title = title;
            this.describe = describe;
        }

        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();
        LoginedUser loginedUser = LoginedUser.getInstance();

        private int approveId;
        private string title;
        private string describe;

        private int userId;
        private int currApprover;
        private int firstApprover;
        private int lastApprover;

        private void button1_Click(object sender, EventArgs e)
        {
            string unapproveTime = DateTime.Now.ToString("g");
            query.insert("s5585452.Approver(approvalId, approver, approveTime, approveResult, approveMemo)")
                .values($"({approveId}, {loginedUser.UserId}, '{unapproveTime}', false, '{textBox4.Text}')");
            int status1 = dbManager.ExecuteNonQueury(query.query);

            updateCurrApprover();
            query.update("s5585452.Approval")
                .set($"currApprover = {currApprover}")
                .where($"approveId = {approveId}");
            int status2 = dbManager.ExecuteNonQueury(query.query);
            if (status1 > 0 && status2 > 0)
            {
                MessageBox.Show("반려되었습니다!");
                this.Close();
            }
        }
        private void updateCurrApprover()
        {
            if (int.Parse(loginedUser.UserId) == lastApprover) { currApprover = firstApprover; }
            else { currApprover = userId; }

        }
        private void loadInfo()
        {
            query.select("userId, currApprover, firstApprover, secondApprover")
                .from("s5585452.Approval")
                .where($"approveId = {approveId}");
            DataTable dt = dbManager.FindDataTable(query.query);
            userId = int.Parse(dt.Rows[0][0].ToString());
            currApprover = int.Parse(dt.Rows[0][1].ToString());
            firstApprover = int.Parse(dt.Rows[0][2].ToString());
            lastApprover = int.Parse(dt.Rows[0][3].ToString());
        }

        private void FormUnApprove_Load(object sender, EventArgs e)
        {
            loadInfo();
            textBox1.Text = approveId.ToString();
            textBox2.Text = title;
            textBox3.Text = describe;
        }
    }
}
