using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr1;

            iArr1 = new int[5];
            int[] iArr2 = new int[5];

            for (int i = 0; i<5; i++)
            {
                iArr1 [i] = i;
                iArr2[i] = i + 10;
            }

            for (int i = 0; i<iArr1.Length; i++)
            {
                Console.WriteLine("iArr1[{0}]= {1}, iArr2[{2}]= {3}", i, iArr1[i], i, iArr2[i]);
            }

            Console.WriteLine();

            int[] iArr3 = new int[5] { 1, 2, 3, 4, 5 };


            foreach (int iVal in iArr3)
            {
                Console.WriteLine("iArr2[] = {0}", iVal);
            }
        }
    }
}
