using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using System.IO;

namespace HMS.DL
{
    class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();

        public static void addIntoList(Customer c)
        {
            customers.Add(c);
        }

        public static void removeCustomer(int idx)
        {
            customers.RemoveAt(idx);
        }

        public static void editCustomer(int idx, Customer c)
        {

            customers[idx].Name = c.Name;
            customers[idx].Mobile = c.Mobile;
            customers[idx].Email = c.Email;
            customers[idx].Cnic = c.Cnic;

        }


        public static void readDataFromFile(string path)
        {

            StreamReader file = new StreamReader(path);
            string record;
            int count = 0;
            while ((record = file.ReadLine()) != null)
            {
                string[] sparseData = record.Split(',');
                string name, mobile, email , cnic;

                name = sparseData[0];
                mobile = sparseData[1];
                email = sparseData[2];
                cnic = sparseData[2];

                Customer c = new Customer(name , mobile , email , cnic);
                addIntoList(c);
                count++;

            }
            file.Close();


        }

        public static void storeIntofile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach(Customer cus in customers)
            {
                file.WriteLine(cus.Name + "," + cus.Mobile + "," + cus.Email + "," + cus.Cnic);
            }
            file.Flush();
            file.Close();
        }
    }
}
