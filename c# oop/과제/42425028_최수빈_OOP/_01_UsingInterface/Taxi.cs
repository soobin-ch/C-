using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UsingInterface
{
    internal class Taxi:ICar
    {
        public void Run()
        {
            Console.WriteLine("택시가 달립니다.");
        }
    }
}
