using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InheritanceWindowsApp
{
    class Bus : Vehicle
    {
        public int iMaxPassengers;

        public Bus(string type, string maker, string color, int price, string filename, int maxPassengers) : base(type, maker, color, price, filename)
        {
            this.iMaxPassengers = maxPassengers;
        }
    }
}
