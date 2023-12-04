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
            query.select("approveId as 결재아이디, userId as 기안자 , 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모, approveStatus as 결재상태")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id");
            DataTable dt = dbManager.FindDataTable(query.query);
            return dt;
        }

        public DataTable continuingApproveSearch()
        {
            query.select("approveId as 결재아이디, userId as 기안자 , 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모, approveStatus as 결재상태")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id")
                .where("approveStatus = 0");
            DataTable dt = dbManager.FindDataTable(query.query);
            return dt;
        }

        public DataTable endedApproveSearch()
        {
            query.select("approveId as 결재아이디, userId as 기안자 , 이름, subClass as 관련업무, approveTitle as 결재제목, approveMemo as 결재메모, approveStatus as 결재상태")
                .from("s5585452.Approval left join s5585452.사원 on s5585452.Approval.userId = s5585452.사원.사원Id")
                .where("approveStatus = 1");
            DataTable dt = dbManager.FindDataTable(query.query);
            return dt;
        }

    }
}
