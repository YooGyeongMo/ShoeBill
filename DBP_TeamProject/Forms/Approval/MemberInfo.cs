
namespace DBP_TeamProject.Forms.Approval
{
    internal class MemberInfo
    {
        private int memberId;
        private string memberName;
        private string department;
        private string position;

        public int MemberId { get => memberId; set => memberId = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }    
    }
}
