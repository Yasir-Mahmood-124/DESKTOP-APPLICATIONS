using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.BL;

namespace HMS.DL
{
    class MUserDL
    {
        public static List<MUser> users = new List<MUser>();

        public static void addUserIntoList(MUser u)
        {
            users.Add(u);
        }



        public static void readDataFromFile(string path)
        {

            StreamReader file = new StreamReader(path);
            string record;
            int count = 0;
            while ((record = file.ReadLine()) != null)
            {
                string[] sparseData = record.Split(',');
                string userName, password, role;

                userName = sparseData[0];
                password = sparseData[1];
                role = sparseData[2];

                MUser user = new MUser(userName, password, role);
                addUserIntoList(user);
                count++;

            }


        }

        public static void storeIntofile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getUserName() + "," + user.getPassword() + "," + user.getRole());
            file.Flush();
            file.Close();
        }

    }
}
