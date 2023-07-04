using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DL;

namespace HMS.BL
{
    class Booked
    {
        private string type;
        private int stays;
        private float bill;

        public string Type { get => type; set => type = value; }
        public int Stays { get => stays; set => stays = value; }

        

        public Booked(string type , int stays , float bill)
        {
            this.Type = type;
            this.Stays = stays;
            this.bill = bill;
        }

        public string gettype()
        {
            return this.Type;
        }

        public void setType(string type)
        {
            this.Type = type;
        }

        public int getStays()
        {
            return this.Stays;
        }

        public void setStya(int stays)
        {
            this.Stays = stays;
        }

        public float getBill()
        {
            return this.bill;
        }

        public void setBill(float bill)
        {
            this.bill = bill;
        }

        public Booked()
        {

        }

       
    }
}
