using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DL;

namespace HMS.BL
{
    class RoomPrice
    {
        private int fiveStar;
        private int fourStar;
        private int threeStar;
        private int twoStar;

        public RoomPrice(int fiveStar, int fourStar, int threeStar, int twoStar)
        {
            this.fiveStar = fiveStar;
            this.fourStar = fourStar;
            this.threeStar = threeStar;
            this.twoStar = twoStar;
        }

        public RoomPrice()
        {

        }

        public int getFive()
        {
            return this.fiveStar;
        }

        public int getFour()
        {
            return this.fourStar;
        }

        public int getThree()
        {
            return this.threeStar;
        }

        public int getTwo()
        {
            return this.twoStar;
        }

        public void setFive(int fiveStar)
        {
            this.fiveStar = fiveStar;
        }

        public void setFour(int fourStar)
        {
            this.fourStar = fourStar;
        }

        public void setThree(int threeStar)
        {
            this.threeStar = threeStar;

        }

        public void setTwo(int twoStar)
        {
            this.twoStar = twoStar;

        }
    }
}
