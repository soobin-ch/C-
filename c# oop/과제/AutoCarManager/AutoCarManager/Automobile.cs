using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCarManager
{
    internal class Automobile
    {
        protected string sType;
        protected string sMaker;
        protected int iPrice;


        public Automobile() {
        
        }

        public Automobile(string sType, string sMaker, int iPrice)
        {
            this.sType = sType;
            this.sMaker = sMaker;
            this.iPrice = iPrice;
        }


        public string SType { get => sType; }
        public string SMaker { get=> sMaker; }

        public int IPrice { get => iPrice; set => iPrice = value;}


        public void DisplayInfo()
        {
            Console.WriteLine("차종: " + this.SType);
            Console.WriteLine("차브랜드: " + this.SMaker);
            Console.WriteLine("차가격 : " + this.IPrice);


        }

    }
}
