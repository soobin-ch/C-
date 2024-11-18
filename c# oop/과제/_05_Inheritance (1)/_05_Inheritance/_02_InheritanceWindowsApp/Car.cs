using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InheritanceWindowsApp
{
    class Car : Vehicle
    {
        public int iMaxSeats;

        public Car(string type, string maker, string color, int price, string filename, int maxSeats) : base(type, maker, color, price, filename)
        {
            this.iMaxSeats = maxSeats;
        }
    }
}
