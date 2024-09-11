using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AutomobileConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Automobile myCar;
            myCar = new Automobile();

            myCar.type = "승용차";
            myCar.speed = 0;

            Console.WriteLine("{0} 의 속도: {1} ", myCar.type, myCar.speed);

            myCar.SpeedUp(100);
            Console.WriteLine("{0} 의 속도: {1} ", myCar.type, myCar.speed);
            myCar.SpeedDown(20);
            Console.WriteLine("{0} 의 속도: {1}", myCar.type, myCar.speed);
            myCar.Stop();
            Console.WriteLine("{0}의 속도: {1}", myCar.type, myCar.speed);

            Automobile myCar1 = new Automobile();
            Automobile myCar2 = new Automobile();

        
        }

    }
}
