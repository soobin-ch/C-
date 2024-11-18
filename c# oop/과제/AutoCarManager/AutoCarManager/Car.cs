using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCarManager
{
    internal class Car : Automobile
    {
        private int maxSeats;

        public Car()
        {

        }

        public Car(string sType, string sMaker, int iPrice, int maxSeats) :base(sType, sMaker, iPrice)
        {
            this.maxSeats = maxSeats;
        }

        public int MaxSeats
        {
            get => maxSeats;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("좌석수 : " + this.MaxSeats);
        }

        


    }
}
