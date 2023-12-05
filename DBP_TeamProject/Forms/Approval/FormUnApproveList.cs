using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject.Forms.Approval
{
    public partial class FormUnApproveList : Form
    {
        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();

        int approveId;
        List<UnApprove> unApproveList = new List<UnApprove>();

        public FormUnApproveList(int approveId)
        {
            InitializeComponent();
            this.approveId = approveId;
        }

        public int ApproveId { get => approveId; set => approveId = value; }

        private void setUnApproveList()
        {
            query.select("approverId, approver, approveTime, approveMemo, 이름")
                .from("s5585452.Approver left join s5585452.사원 on s5585452.Approver.approver = s5585452.사원.사원Id")
                .where($"approvalId = {approveId} and approveResult = 0");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dbManager.CloseConnection();

            unApproveList.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UnApprove unApprove = new UnApprove();
                unApprove.ApproveId = int.Parse(dt.Rows[i][0].ToString());
                unApprove.ApproverId = int.Parse(dt.Rows[i][1].ToString());
                unApprove.UnApproveDate = dt.Rows[i][2].ToString();
                unApprove.UnApproveMemo = dt.Rows[i][3].ToString();
                unApprove.ApproverName = dt.Rows[i][4].ToString();
                unApproveList.Add(unApprove);
            }
        }

        private void setUnApprover()
        {
            foreach (UnApprove unApprove in unApproveList)
            {
                if (comboBox1.Items.Contains(unApprove.ApproverId)) continue;
                comboBox1.Items.Add($"{unApprove.ApproverName} - {unApprove.ApproverId}");
            }
        }

        private void setUnApproveDate()
        {
            textBox1.Clear();
            comboBox2.Items.Clear();
            foreach (UnApprove unApprove in unApproveList)
            {
                if (comboBox1.SelectedItem.ToString().Contains(unApprove.ApproverId.ToString()))
                {
                    comboBox2.Items.Add(unApprove.UnApproveDate);
                }
            }
        }

        private void setUnApproveMemo()
        {
            textBox1.Clear();
            textBox1.Text = unApproveList.Find(x => comboBox1.Text.Contains(x.ApproverId.ToString()) && x.UnApproveDate == comboBox2.Text).UnApproveMemo;
        }

        private void FormUnApproveList_Load(object sender, EventArgs e)
        {
            setUnApproveList();
            setUnApprover();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            setUnApproveDate();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            setUnApproveMemo();
        }
    }
}
