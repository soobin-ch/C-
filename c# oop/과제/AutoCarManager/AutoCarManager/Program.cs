using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCarManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("승용차", "벤츠", 1000000, 4);
            car.DisplayInfo();

            car.IPrice = 500000;


            car.DisplayInfo();



        }
    }
}
