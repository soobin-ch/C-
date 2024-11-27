using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ExpLambdaWithoutArgs
{
    internal class Program
    {
        delegate int DelegateMethod(int a, int b);
        delegate void DelegateMethodNoRet(string work);
        delegate void DelegateMethodNoArgsoRet();
        static void Main(string[] args)
        {

            DelegateMethodNoArgsoRet printTitle = () => Console.WriteLine("람다식 연습");
            DelegateMethodNoRet printWork = (work) => Console.WriteLine(work);
            DelegateMethod add = (a, b) => a + b;
            printTitle();
            printWork("덧셈");
            Console.WriteLine("11+22={0}", add(11, 22));

        }
    }
}
