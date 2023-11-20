using GookBabProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            query.select("approveId, UserName, subClass, approveTitle, approveMemo")
                .from("s5585452.Approval")
                .where($"approveId = {loginedUser.UserId}");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dataGridView1.DataSource = dt;
        }

        private void approveContinueDataSearch()
        {
            query.select("approveId, UserName, subClass, approveTitle, approveMemo")
                .from("s5585452.Approval")
                .where($"approveId = {loginedUser.UserId} and approveStatus = 0");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dataGridView1.DataSource = dt;
        }

        private void approveEndDataSearch()
        {
            query.select("approveId, UserName, subClass, approveTitle, approveMemo")
                .from("s5585452.Approval")
                .where($"approveId = {loginedUser.UserId} and approveStatus = 1");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
            dataGridView1.DataSource = dt;
        }

        private void approveListUpdate()
        {
            query.select("approveId, userName, subClass,approveTitle, approveMemo")
                .from("s5585452.Approval")
                .where($"currApprover = {loginedUser.UserId} and approveStatus = 0");
            DataTable dt = dbManager.InitDBManager().FindDataTable(query.query);
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

        private void FormApproval_Load(object sender, EventArgs e)
        {
            tabControlSelected();
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
    }
}
