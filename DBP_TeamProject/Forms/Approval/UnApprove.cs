using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_TeamProject.Forms.Approval
{
    internal class UnApprove
    {
        private int approveId;
        private int approverId;
        private string unApproveDate;
        private string unApproveMemo;

        public int ApproveId { get => approveId; set => approveId = value; }
        public int ApproverId { get => approverId; set => approverId = value; }
        public string UnApproveDate { get => unApproveDate; set => unApproveDate = value; }
        public string UnApproveMemo { get => unApproveMemo; set => unApproveMemo = value; }
    }
}
