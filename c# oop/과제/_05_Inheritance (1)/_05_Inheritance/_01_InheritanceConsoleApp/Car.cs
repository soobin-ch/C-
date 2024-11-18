using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceConsoleApp
{
    internal class Car : Vehicle
    {
        public int iMaxSeats;

        public Car(string type, string maker, int color, int price, int maxSeats) : base(type, maker, color, price)
        {
            Console.WriteLine("===인수를 가진 Car 생성자===");

            this.iMaxSeats = maxSeats;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("===Car 클래스에서의 정보 출력===");

            Console.WriteLine("승차인원 : {0}", this.iMaxSeats);
        }
    }
}
