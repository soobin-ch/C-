using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BubbleSort
{
    internal class Program
    {


        public static void BubbleSort(int[] items)
        {
            if (items == null) return;

            for (int i = items.Length-1; i >=0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    if (items[j] > items[j + 1])
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

                BubbleSort(items);

                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine(items[i].ToString());
                }
            }
        }
    }



