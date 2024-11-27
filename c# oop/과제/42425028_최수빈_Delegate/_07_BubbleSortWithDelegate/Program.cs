using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _07_BubbleSortWithDelegate
{
    internal class Program
    {
        public delegate bool ComparisonHandler(int prev, int next); 

        public static bool Asc(int prev, int next)
        {
            return prev > next;
        }
        public static bool Desc(int prev, int next)
        { return prev < next; }

        public static bool Alphabetic(int prev, int next)
        {
            int comparison = prev.ToString().CompareTo(next.ToString());
            return comparison > 0;
        }

        public static void BubbleSort(int[] items, ComparisonHandler Compare)
        {
            if (items == null) return;
            for (int i = items.Length-1; i>=0; i--)
            {
                for (int j = 0; j<i; j++)
                {
                    if (Compare(items[j], items[j+1]))
                    {
                        int temp = items[j];
                        items[j] = items[j+1];
                        items[j+1]= temp;

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

            BubbleSort(items, Asc);

            Console.WriteLine("===Ascending Order===");
            for (int i = 0;i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }

            BubbleSort(items, Desc);
            Console.WriteLine("===Descending Order===");
            for(int i = 0; i<items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }

            BubbleSort(items, Alphabetic);
            Console.WriteLine("===Ascending Order===");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
