using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DL;

namespace HMS.BL
{
    class Discount
    {
        private int discounts;

        public Discount(int discounts)
        {
            this.discounts = discounts;
        }

        public Discount()
        {

        }

        public int getDiscounts()
        {
            return this.discounts;
        }

        public void setDiscounts(int discounts)
        {
            this.discounts = discounts;
        }
    }
}
