using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TypeInfo
{
    internal class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("난 프린터 클래스로 만들어 졌다우");
        }
    }
}
