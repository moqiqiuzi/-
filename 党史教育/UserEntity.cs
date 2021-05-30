using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 党史教育
{
    public class UserEntity
    {
        private int userid;
        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}