using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int j = 3 / zero;
            }

            catch (Exception e) {

                    Console.WriteLine("예외 발생 :{0}", e.Message);

                }
            }
        }
    }

