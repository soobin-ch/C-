using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_QueueApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();

            Console.WriteLine("EnQueue() 메서드로 자료입력");
            myQ.Enqueue("두원공과대학교");
            myQ.Enqueue("컴퓨터공학과");
            myQ.Enqueue("1학년");

            printQueue(myQ);


        }

        static void printQueue(Queue myQ)
        {
            Console.WriteLine("myQ");
            Console.WriteLine();
            Console.WriteLine("Count:{0} ", myQ.Count);
            Console.WriteLine("DeQueue() 메서드로 자료 출력");
            Console.WriteLine("Values");

            while (myQ.Count > 0)
            {
                Console.WriteLine("\t{0}", myQ.Dequeue());
            }

        }
    }
}
