using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;

namespace HMS.DL
{
    class BookedDL
    {
        public static List<Booked> bookings = new List<Booked>();

        public static void addTypeIntoList(Booked b)
        {
            bookings.Add(b);
        }
    }
}
