using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ArrayListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mLists = new ArrayList();
            Console.WriteLine("ArrayList의 수용한계 (초기) : {0}", mLists.Capacity);

            Console.WriteLine("3개의 아이템 추가");
            mLists.Add("123");
            mLists.Add("456");
            mLists.Add("789");

            Console.WriteLine("인덱스 1번 위치에 아이템 추가");
            mLists.Insert(1, "100");


            int i = 1;
            Console.WriteLine("ArrayList[{0}]:{1}", i, mLists[i]);
            Console.WriteLine("Length of mLists :{0}", mLists.Count);

            foreach (object o in mLists) Console.WriteLine(o);
            Console.WriteLine();

            Console.WriteLine("특정위치 및 값에 해당하는 아이템 삭제");
            mLists.RemoveAt(1);
            mLists.Remove("123");

            Console.WriteLine("ArrayList의 수용한계 (자료 삭제 후): {0}", mLists.Capacity);

            Console.WriteLine("Length if mLists : {0}", mLists.Count);

            foreach (object o in mLists) Console.WriteLine(o);

        }
    }
}
