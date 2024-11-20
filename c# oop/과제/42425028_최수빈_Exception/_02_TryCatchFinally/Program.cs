using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                Console.WriteLine("try 블럭 시작.");
                int zero = 0;
                int i=3 /zero;
                Console.WriteLine("try 블럭 끝");
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외 : {0}", ex.Message);


            }
            finally
            {

                Console.WriteLine("finally 블럭은 마지막에 무조건 실행");

            }



        }
    }
}
