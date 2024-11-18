using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int ix = 13, iy = 7;

            Console.WriteLine("\n 정수형 연산");
            Console.WriteLine("{0} + {1} = {2}", ix, iy, IntCalculator.Plus(ix, iy));
            Console.WriteLine("{0} - {1} = {2}", ix, iy, IntCalculator.Minus(ix, iy));
            Console.WriteLine("{0} * {1} = {2}", ix, iy, IntCalculator.Multiply(ix, iy));
            Console.WriteLine("{0} / {1} = {2}", ix, iy, IntCalculator.Divide(ix, iy)); 
            Console.WriteLine("{0} / {1} = {2}" , ix, iy, IntCalculator.Modulo(ix, iy));

            double dx = 13.3, dy = 7.0;
            Console.WriteLine("\n 실수형 연산");
            Console.WriteLine("{0} + {1} = {2}", dx, dy, DoubleCalculator.Plus(dx, dy));
            Console.WriteLine("{0} - {1} = {2}", dx, dy, DoubleCalculator.Minus(dx, dy));
            Console.WriteLine("{0} * {1} = {2}", dx, dy, DoubleCalculator.Multiply(dx, dy));
            Console.WriteLine("{0} / {1} = {2}", dx, dy, DoubleCalculator.Divide(dx, dy));


        }
    }
}
