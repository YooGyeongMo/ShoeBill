using System.Data;

namespace DBP_TeamProject.Forms.Approval
{
    public partial class FormApproveContinue : Form
    {
        public FormApproveContinue(int approveId, string title, string describe)
        {
            InitializeComponent();
            this.approveId = approveId;
            this.title = title;
            this.describe = describe;
        }

        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();
        LoginedUser loginedUser = LoginedUser.getInstance();

        private int firstApprover;

        private int approveId;
        private string title;
        private string describe;

        private void loadInfo()
        {
            query.select("firstApprover")
            .from("s5585452.Approval")
            .where($"approveId = {approveId}");
            DataTable dt = dbManager.FindDataTable(query.query);

            firstApprover = int.Parse(dt.Rows[0][0].ToString());

        }

        private void FormApproveContinue_Load(object sender, EventArgs e)
        {
            loadInfo();
            textBox1.Text = approveId.ToString();
            textBox2.Text = title;
            textBox3.Text = describe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text.Equals(""))
            {
                MessageBox.Show("새로운 결재 내용을 결재 내용변경란에 적어주세요.");
                return;
            }
            query.update("s5585452.Approval")
                .set($"approveMemo = '{textBox4.Text}', currApprover = {firstApprover}")
                .where($"approveId = {approveId}");
            int status = dbManager.ExecuteNonQueury(query.query);
            if(status > 0)
            {
                MessageBox.Show("결재내용이 변경되어 상위 결재자에게 전달됐습니다!");
            }
            this.Close();
        }
    }
}
