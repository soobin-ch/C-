using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("승용차", "현대", 0, 30000000, 5);

            myCar.DisplayInfo();
        }
    }
}