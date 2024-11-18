using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceConsoleApp
{
    internal class Vehicle
    {
        public string sType;
        public string sMaker;
        public int iColor;
        public int iPrice;

        public Vehicle()
        {
            Console.WriteLine("===인수없는 Vehicle 생성자===");
        }
        public Vehicle(string type, string maker, int color, int price)
        {
            Console.WriteLine("===인수를 가진 Vehicle 생성자===");

            this.sType = type;
            this.sMaker = maker;
            this.iColor = color;
            this.iPrice = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("===Vehicle 클래스에서의 정보 출력===");
            Console.WriteLine("차종 : {0}", this.sType);
            Console.WriteLine("제조사 : {0}", this.sMaker);
            Console.WriteLine("색깔 : {0}", this.iColor);
            Console.WriteLine("가격 : {0}", this.iPrice);
        }
    }
}

