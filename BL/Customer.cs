using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DL;

namespace HMS.BL
{
    class Customer
    {
        private string name;
        private string mobile;
        private string email;
        private string cnic;
        

        public string Name { get => name; set => name = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Email { get => email; set => email = value; }
        public string Cnic { get => cnic; set => cnic = value; }

        public Customer(string name, string mobile, string email, string cnic)
        {
            this.Name = name;
            this.Mobile = mobile;
            this.Email = email;
            this.Cnic = cnic;
        }

        

     

        public Customer()
        {

        }

        

        public string getName()
        {
            return this.Name;
        }

        public string getMobile()
        {
            return this.Mobile;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public string getCnic()
        {
            return this.Cnic;
        }


    }
}
