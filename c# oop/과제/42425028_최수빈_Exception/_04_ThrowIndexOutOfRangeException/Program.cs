using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ThrowIndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===1.프로그램 시작\n");
            try
            {
                Console.WriteLine("===2.try 블럭\n");
                throw (new IndexOutOfRangeException());
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine("===3. catch블럭\n");
                    Console.WriteLine("----e.Message :" + ex.Message);
                    Console.WriteLine("----e.ToString() :"+ ex.ToString());
                    Console.WriteLine("----예외 발생 장소:"+ ex.Source);
                }
            }
        }
    }
}
