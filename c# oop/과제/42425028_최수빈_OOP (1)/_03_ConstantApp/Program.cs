using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConstantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SInput;
            Console.WriteLine("치수기호 입력: (S)mall (M)edium (L)arge (X)large (^)quit");
            while ((SInput = Console.ReadLine()) != null)
            {
                switch(SInput)
                {

                    case "S": Console.WriteLine(Sizes.S); break;
                    case "M": Console.WriteLine(Sizes.M); break;
                    case "L": Console.WriteLine(Sizes.L); break;
                    case "X": Console.WriteLine(Sizes.XL); break;
                    default: Console.WriteLine("잘못된 사이즈 입력"); break;
                }

                Console.WriteLine("치수기호 입력: (S)mall (M)edium (L)arge (X)large (^)quit");
            }

        }
    }
}
