using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ReadOnlyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sInput;

            Sizes mSizes = new Sizes();

            Console.WriteLine("치수기호 입력 : (S)mall (M)edium (L)arge (X)large (q)uit");


            while ((sInput = Console.ReadLine()) != null)
            {

                switch (sInput)
                {
                    case "S": Console.WriteLine(mSizes.S); break;
                    case "M": Console.WriteLine(mSizes.M); break;
                    case "L": Console.WriteLine(mSizes.L); break;
                    case "X": Console.WriteLine(mSizes.XL); break;
                    default: Console.WriteLine("잘못된 사이즈 입력"); break;

                }

                Console.WriteLine("치수기호 입력 : (S)mall (M)edium (L)arge (X)large (q)uit");
            }
        }
    }
}
