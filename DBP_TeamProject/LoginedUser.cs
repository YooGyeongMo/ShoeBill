using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_TeamProject
{
    internal class LoginedUser
    {

        private static LoginedUser instance;
        private LoginedUser() { }
        public static LoginedUser getInstance()
        {
            if (instance == null) { instance = new LoginedUser(); }
            return instance;
        }
        private int userId;
        private string name;
        private string department;
        private string position;

        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
    }
}
