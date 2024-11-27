using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConceptOfDelegate
{
    internal class Program
    {
        delegate int DelegateMethod(int a, int b);
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Average(int a, int b)
        {
            return (int)((a + b) / 2.0);
        }
        static void Main(string[] args)
        {

            Console.Write("값 a를 입력하세요 :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("값 b를 입력하세요 :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("===메서드를 직접 호출하는 경우===");
            Console.WriteLine("{0} + {1} = {2}", a,b, Sum(a,b));
            Console.WriteLine("({0} + {1} = {2}", a,b, Sum(a,b));
            Console.WriteLine("({0} + {1})/2 = {2}\n", a,b, Average(a,b));

            Console.WriteLine("====메서드를 대리 호출하는 경우===");
            DelegateMethod method = Sum;
            Console.WriteLine("{0} + {1} = {2}", a, b, method(a, b));
            method = new DelegateMethod(Average);

            Console.WriteLine("({0} + {1})/2 = {2}\n", a, b, method(a, b));
        }
    }
}
