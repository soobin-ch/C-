using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InheritanceWindowsApp
{
    class Vehicle
    {
        public string sType;
        public string sMaker;
        public string sColor;
        public int iPrice;
        public string sPictureFilename;

        public Vehicle(string type, string maker, string color, int price, string filename)
        {
            this.sType = type;
            this.sMaker = maker;
            this.sColor = color;
            this.iPrice = price;
            this.sPictureFilename = filename;
        }
    }
}
