using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BubbleSortWithAscDesc
{
    internal class Program
    {

        public enum SortType
        {
            Asc,Desc
        }

        public static void BubbleSort(int[] items, SortType sortType)
        {
            if (items == null) return;

            for (int i = items.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {

                    bool bSwap = false;

                    switch (sortType)
                    {
                        case SortType.Asc:
                            bSwap = items[j] > items[j + 1]; break;
                        case SortType.Desc:
                            bSwap = items[j] < items[j + 1]; break;
                    }

                    if (bSwap)
                    {
                        int temp = items[j];
                        items[j] = items[j+1];
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
                    Console.WriteLine("정수값 입력 :");
                    items[i] = int.Parse(Console.ReadLine());
                }
                BubbleSort(items, SortType.Asc);

            Console.WriteLine("===Ascending Order==");

            for (int i = 0;i < items.Length; i++) {
                Console.WriteLine(items[i].ToString());
            }

            BubbleSort(items, SortType.Desc);
            Console.WriteLine("===Descending Order===");
            for (int i = 0; i <= items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }

        }
    }
}
