using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_TeamProject.Forms.Approval
{
    internal class AdminApproveSearch
    {

        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();

        public DataTable allApproveSearch()
        {
            query.select("approveId, userId, approveTitle, approveMemo, approveStatus")
                .from("s5585452.Approval");
            DataTable dt = dbManager.FindDataTable(query.query);
            return dt;
        }

        public DataTable continuingApproveSearch()
        {
            query.select("approveId, userId, approveTitle, approveMemo, approveStatus")
                .from("s5585452.Approval")
                .where("approveStatus = 0");
            DataTable dt = dbManager.FindDataTable(query.query);
            return dt;
        }

        public DataTable endedApproveSearch()
        {
            query.select("approveId, userId, approveTitle, approveMemo, approveStatus")
                .from("s5585452.Approval")
                .where("approveStatus = 1");
            DataTable dt = dbManager.FindDataTable(query.query);
            return dt;
        }

    }
}
