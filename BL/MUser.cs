using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DL;


namespace HMS.BL
{
    class MUser
    {
        private string userName;
        private string password;
        private string role;

        public string getUserName()
        {
            return this.userName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getRole()
        {
            return this.role;
        }



        public MUser(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public MUser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

        }

        public bool isAdmin()
        {
            if (this.role == "Admin")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
