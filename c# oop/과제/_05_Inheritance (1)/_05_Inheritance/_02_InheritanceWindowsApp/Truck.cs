using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InheritanceWindowsApp
{
    class Truck : Vehicle
    {
        public int iMaxCargo;

        public Truck(string type, string maker, string color, int price, string filename, int maxCargo) : base(type, maker, color, price, filename)
        {
            this.iMaxCargo = maxCargo;
        }
    }
}
