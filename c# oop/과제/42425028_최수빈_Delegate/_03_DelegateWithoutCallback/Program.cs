using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DelegateWithoutCallback
{
    internal class Program
    {
        delegate int DelegateMethod(int a, int b);
        static int Plus(int a, int b) { return a + b; }
        static int Minus(int a, int b) { return a - b; }
        static void Main(string[] args)
        {

            Console.WriteLine("값 a를 입력하세요 :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("값 b를 입력하세요 :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();


            DelegateMethod calculate = Plus;
            Console.WriteLine("{0} + {1} = {2}", a,b, calculate(a,b));
            calculate = new DelegateMethod(Minus);
            Console.WriteLine("{0} - {1} = {2}\n\n",a,b, calculate(a,b));


        }
    }
}
