using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 10;
            Console.WriteLine("반지름 {0}인 원의 면적 : {1}", r, Math.PI * r *r);

            int iNum = 3;
            Console.WriteLine("{0} 의 절대값 : {1}", iNum, Math.Abs(iNum));
            double dNum = -4.0;

            Console.WriteLine("{0}의 절대값 :{1}", dNum, Math.Abs(dNum));

            //최댓값
            int iNum1 = 3;
            int iNum2 = 4;
            Console.WriteLine("{0}, {1} 의 최대값 :{2}", iNum1, iNum2, Math.Max(iNum1, iNum2));
            double dNum1 = 4.0;
            double dNum2 = 4.1;
            Console.WriteLine("{0},{1}의 최대값 : {2}", dNum1, dNum2, Math.Max(dNum1, dNum2));

            //최솟값
            Console.WriteLine("{0},{1} 의 최소값 :{2}", iNum1, iNum2, Math.Min(iNum1, iNum2));
            Console.WriteLine("{0},{1}의 최소값 :{2}", dNum1,dNum2, Math.Min(dNum1, dNum2));

            //거듭제곱
            Console.WriteLine("{0}의 {1} 제곱 :{2}", iNum1, iNum2, Math.Pow(iNum1, iNum2));
        
        }
    }
}
