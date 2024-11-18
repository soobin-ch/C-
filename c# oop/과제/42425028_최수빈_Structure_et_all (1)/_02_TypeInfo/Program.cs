using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TypeInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter myPrinter = new Printer();
            myPrinter.Print();
            Console.WriteLine("myPrinter의 자료형: {0}", myPrinter.GetType());

            Point myPt  = new Point(30,70);

            Console.WriteLine("myPt.x :{0},  myPt.y :{1}", myPt.x, myPt.y);
            Console.WriteLine("myPt의 자료형 :{0}", myPt.GetType());
            int iNum = 3;

            Console.WriteLine("iNum의 자료형 :{0}", iNum.GetType());

        }
    }
}
