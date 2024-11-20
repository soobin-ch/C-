using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_IndexerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int I_MAX = 6;
            NameCard friends = new NameCard(I_MAX);

            friends[0] = "홍길동";
            friends[2] = "갑순이";
            friends[3] = "갑돌이";

            for (int i = 0; i < I_MAX; i++)
            {

                Console.WriteLine(friends[i]);

            }
        }
    }
}
