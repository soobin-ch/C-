using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager
{
    internal class Car
    {
        private string sType;
        private string sMaker;
        private int iPrice;
        private string sOwner;


        public Car() { }

        public Car(string sType, string sMaker, int iPrice, string sOwner)
        {
            this.sType = sType;
            this.sMaker = sMaker;
            this.iPrice = iPrice;
            this.sOwner = sOwner;
        }


        public string SType
        {
            get
            {
                return this.sType;
            }
        }

        public string SMaker
        {
            get
            {
                return this.sMaker;
            }
        }
        public int IPrice
        {
            get
            {
                return this.iPrice;
            }
            set
            {
                this.iPrice= value;
            }
        }


        public string SOwner
        {
           get
            {
                return this.sOwner;
            }
            set
            {
                this.sOwner= value; 
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("차종 :" + this.SType);
            Console.WriteLine("브랜드 : " + this.sMaker);
            Console.WriteLine("가격: " +this.iPrice);
            Console.WriteLine("주인: " + this.sOwner);
        }

    }
}
