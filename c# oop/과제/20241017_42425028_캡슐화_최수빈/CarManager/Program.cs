using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("승용차","벤츠", 100000, "최수빈");

            car.DisplayInfo();

            car.IPrice = 1500000;
            car.SOwner = "김남숙";

            car.DisplayInfo(); 

            Thread.Sleep(10000);

        }
    }
}
