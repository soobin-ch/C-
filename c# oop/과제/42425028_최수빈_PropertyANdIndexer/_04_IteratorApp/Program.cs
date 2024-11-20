using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteratorApp
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


            Console.WriteLine("=====Indexer를 이용한 출력======");

            for (int i = 0; i< I_MAX; i++)
            {
                Console.WriteLine("friends[{0}] --> {1}", i, friends[i]);
            }

            Console.WriteLine("======foreach문을 이용한 출력 =====");
            foreach (string  friend in friends)
            {
                Console.WriteLine("friends[] --> {0}", friend);

            }

        }
    }
}
