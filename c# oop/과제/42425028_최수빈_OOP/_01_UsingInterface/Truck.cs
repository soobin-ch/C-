using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UsingInterface
{
    internal class Truck :ICar
    {
        public void Run()
        {
            Console.WriteLine("트럭이 달립니다.");
        }
    }
}
