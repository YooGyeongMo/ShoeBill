using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_TeamProject.Forms.Approval
{
    public partial class FormApproveList : Form
    {
        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();

        int approveId;
        List<UnApprove> approveList = new List<UnApprove>();

        public FormApproveList(int approveId)
        {
            InitializeComponent();
            this.approveId = approveId;
        }


        private void setApproveList()
        {
            query.select("approverId, approver, approveTime, approveMemo, 이름, approveResult")
                .from("s5585452.Approver left join s5585452.사원 on s5585452.Approver.approver = s5585452.사원.사원Id")
                .where($"approvalId = {approveId}");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();

            approveList.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UnApprove approve = new UnApprove();
                approve.ApproveId = int.Parse(dt.Rows[i][0].ToString());
                approve.ApproverId = int.Parse(dt.Rows[i][1].ToString());
                approve.UnApproveDate = dt.Rows[i][2].ToString();
                approve.UnApproveMemo = dt.Rows[i][3].ToString();
                approve.ApproverName = dt.Rows[i][4].ToString();
                approve.ApproveType = Convert.ToInt32(dt.Rows[i][5]);
                approveList.Add(approve);
            }
        }

        private void setApproverList(int approveType)
        {
            comboBoxApprover.Items.Clear();
            foreach (UnApprove approve in approveList)
            {
                if (approve.ApproveType == approveType)
                {
                    if (comboBoxApprover.Items.Contains($"{approve.ApproverName} - {approve.ApproverId}")) continue;
                    comboBoxApprover.Items.Add($"{approve.ApproverName} - {approve.ApproverId}");
                }
            }
        }

        private void setApproveDate(int approveType)
        {
            listBox1.Items.Clear();
            foreach (UnApprove approve in approveList)
            {
                if (comboBoxApprover.SelectedItem.ToString().Contains($"{approve.ApproverName} - {approve.ApproverId}"))
                {
                    if (approve.ApproveType == approveType)
                        listBox1.Items.Add(approve.UnApproveDate);
                }
            }
        }

        private void unApprovedMemoLoad()
        {
            textBox1.Text = approveList.Find(x => x.UnApproveDate.Equals(listBox1.SelectedItem.ToString()) && x.ApproveType == 0).UnApproveMemo;
        }

        private void setApproveType()
        {
            comboBoxApproveType.Items.Add("결재 반려");
            comboBoxApproveType.Items.Add("결재 진행");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int approveType = comboBoxApproveType.SelectedIndex;
            setApproverList(approveType);
            if(approveType == 1) listBox1.Enabled = false;
            else listBox1.Enabled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int approveType = comboBoxApproveType.SelectedIndex;
            setApproveDate(approveType);
        }

        private void FormApproveList_Load(object sender, EventArgs e)
        {
            setApproveType();
            setApproveList();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null )
            {
                MessageBox.Show("결재타입과 결재자모두 선택해주세요!");
                return;
            }
            unApprovedMemoLoad();
        }
    }
}
