using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BubbleSortWithStatementLambda
{
    internal class Program
    {
        public delegate bool ComparisonHandler(int prev, int next);

        public static void BubblSort(int[] items, ComparisonHandler Compare)
        {
            if (items == null) return;

            for (int i = items.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Compare(items[j], items[j + 1]))
                    {
                        int temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }

            }
        }
        static void Main(string[] args)
        {

            int[] items = new int[5];
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write("정수값 입력 :");
                items[i] = int.Parse(Console.ReadLine());


            }

            BubblSort(items, (int prev, int next) => 
            {
                return prev > next;

            });

            Console.WriteLine("===Ascending Order===");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }

            BubblSort(items, (int prev, int next) =>
            {
                return prev < next;
            });

            Console.WriteLine("Descending Order===");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }


            BubblSort(items, (int prev, int next) =>
            {
                return prev.ToString().CompareTo(next.ToString()) > 0;

            });

            Console.WriteLine("===Alphabetic Order===");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
