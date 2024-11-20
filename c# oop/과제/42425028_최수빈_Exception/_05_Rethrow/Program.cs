using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rethrow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===1.프로그램 시작 \n");

            Top  t = new Top();

            try
            {
                t.SayHello();
            }
            catch (Exception e)
            {

                Console.WriteLine("===3. Main()메서드 내부\n");
                Console.WriteLine("----e.Message :" + e.Message);
                Console.WriteLine("----e.ToString() :"+ e.ToString());
                Console.WriteLine("----예외 발생 장소:"+ e.Source);



            }

        }




    }
}
