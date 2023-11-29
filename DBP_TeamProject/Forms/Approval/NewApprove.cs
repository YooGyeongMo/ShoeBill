using System.Data;

namespace DBP_TeamProject.Forms.Approval
{
    internal class NewApprove
    {
        private int approveId;
        private int userId;

        private string relatedWork;
        private string title;
        private string description;

        private int currApprover;
        private int firstApprover;
        private int lastApprover;

        private bool isApproved;

        // 부서이름을 key로 하고 해당 부서의 사원들을 List에 담아서 관리
        public static Dictionary<string, List<MemberInfo>> departmentMember = new Dictionary<string, List<MemberInfo>>();

        // 부서이름을 key로 하고 해당 부서의 업무들을 List에 담아서 관리
        public static Dictionary<string, List<WorkList>> workCategory = new Dictionary<string, List<WorkList>>();

        // 부서이름을 List에 담아서 관리
        public static List<string> departments = new List<string>();

        public int ApproveId { get => approveId; set => approveId = value; }
        public int UserId { get => userId; set => userId = value; }

        public string RelatedWork { get => relatedWork; set => relatedWork = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }

        public int CurrApprover { get => currApprover; set => currApprover = value; }
        public int FirstApprover { get => firstApprover; set => firstApprover = value; }
        public int LastApprover { get => lastApprover; set => lastApprover = value; }

        public bool IsApproved { get => isApproved; set => isApproved = value; }
        

        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();
        LoginedUser loginedUser = LoginedUser.getInstance();


        public void getDepartments()
        {
            query.select("distinct 부서이름").from("s5585452.사원");
            DataTable dt = dbManager.FindDataTable(query.query);
            departments.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                departments.Add(dr[0].ToString());
            }
        }
        public void getDeparmentMember()
        {
            departmentMember.Clear();
            foreach (string i in departments.ToArray())
            {
                query.select("사원ID, 이름, 부서이름, 직급").from("s5585452.사원").where($"부서이름 = '{i}'");
                DataTable dt = dbManager.FindDataTable(query.query);
                List<MemberInfo> members = new List<MemberInfo>();
                foreach(DataRow dr in dt.Rows)
                {
                    MemberInfo member = new MemberInfo();
                    member.MemberId = int.Parse(dr[0].ToString());
                    member.MemberName = dr[1].ToString();
                    member.Department = dr[2].ToString();
                    member.Position = dr[3].ToString();
                    members.Add(member);
                }
                departmentMember.Add(i, members);
            }
        }
        public void getWorkCategory()
        {
            workCategory.Clear();
            foreach (string i in departments.ToArray())
            {
                query.select("대분류명, 중분류명, 소분류명")
                    .from("s5585452.분류_대분류 as large left join s5585452.분류_중분류 as middle on large.대분류ID = middle.대분류ID " +
                    "left join s5585452.분류_소분류 as sub on middle.중분류ID = sub.중분류ID")
                    .where($"대분류명 = '{i}'");
                DataTable dt = dbManager.FindDataTable(query.query);
                List<WorkList> workList = new List<WorkList>();
                foreach (DataRow dr in dt.Rows)
                {
                    WorkList work = new WorkList();
                    work.LargeCategory = dr[0].ToString();
                    work.MediumCategory = dr[1].ToString();
                    work.SubCategory = dr[2].ToString();
                    workList.Add(work);
                }
                workCategory.Add(i, workList);
            }
        }

        public List<string> mediumCategoryLoad(string largeCategory)
        {
            List<WorkList> workList = workCategory[largeCategory].ToList();
            List<string> mediumCategory = new List<string>();
            foreach (WorkList work in workList)
            {
                if(!mediumCategory.Contains(work.MediumCategory))
                {
                    mediumCategory.Add(work.MediumCategory);
                }
            }
            return mediumCategory;
        }

        public List<string> subCategoryLoad(string largeCategory, string mediumCategory)
        {
            List<WorkList> workList = workCategory[largeCategory].ToList();
            List<string> subCategory = new List<string>();
            foreach (WorkList work in workList)
            {
                if (work.MediumCategory.Equals(mediumCategory))
                {
                    subCategory.Add(work.SubCategory);
                }
            }
            return subCategory;
        }

        public List<string> firstApproverLoad(string department)
        {
            List<MemberInfo> members = departmentMember[department].ToList();
            List<string> memberList = new List<string>();
            foreach (MemberInfo member in members)
            {
                memberList.Add(member.MemberName);
            }
            return memberList;
        }
        
        public List<string> lastApproverLoad(string department)
        {
            List<MemberInfo> members = departmentMember[department].ToList();
            List<string> memberList = new List<string>();
            foreach (MemberInfo member in members)
            {
                memberList.Add(member.MemberName);
            }
            return memberList;
        }

        public void createApprove()
        {
            query.insert("s5585452.Approval (userId, subClass, approveTitle, approvememo, currApprover, firstApprover, secondApprover, approveStatus)")
                .values($"({loginedUser.UserId}, '{this.relatedWork}', '{this.title}', '{this.description}', {this.firstApprover}, {this.firstApprover}, {this.lastApprover}, false)").exec();
            int status = dbManager.InitDBManager().ExecuteNonQueury(query.query);
            if(status > 0)
            {
                MessageBox.Show("새로운 결재가 등록되었습니다!");
            }
        }

        public void setFirstApprover(string department, string approver)
        {
            MemberInfo memberInfo = departmentMember[department].Find(x => x.MemberName == approver);
            this.firstApprover = memberInfo.MemberId;
        }
        public void setLastApprover(string department, string approver)
        {
            MemberInfo memberInfo = departmentMember[department].Find(x => x.MemberName == approver);
            this.lastApprover = memberInfo.MemberId;
        }

    }
}
