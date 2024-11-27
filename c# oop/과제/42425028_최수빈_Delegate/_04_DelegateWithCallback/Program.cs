using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DelegateWithCallback
{
    internal class Program
    {
        delegate int DelegateMethod(int a, int b);
        static void Calculator(int a, int b, DelegateMethod myDele)
        {
            Console.WriteLine(myDele(a, b));
        }

        static int plus(int a, int b) { return a + b; } 
        static int minus(int a, int b) { return a - b; }
        static int multiply(int a, int b) { return a * b; }    
        static int divide(int a, int b) { return a / b; }
        static int modulo(int a, int b) { return a % b; }

        static void Main(string[] args)
        {
            DelegateMethod Plus = new DelegateMethod(plus);
            DelegateMethod Minus = new DelegateMethod(minus);
            DelegateMethod Multiply = new DelegateMethod(multiply);
            DelegateMethod Divide = new DelegateMethod(divide);
            DelegateMethod Modulo = new DelegateMethod(modulo);



            Console.Write("값 a를 입력하세요 :");
            int a = int.Parse(Console.ReadLine());  
            Console.WriteLine();
            Console.Write("값 b를 입력하세요 :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Calculator(a,b, Plus);
            Calculator(a,b, Minus);
            Calculator(a,b, Multiply);
            Calculator(a,b, Divide);
            Calculator(a,b, Modulo);



        }
    }
}
