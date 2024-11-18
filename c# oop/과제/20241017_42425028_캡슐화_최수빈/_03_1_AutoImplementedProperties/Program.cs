using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_1_AutoImplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SName = "홍길순";
            person.SGender = "여성";
            person.SAddress = "경기도 파주시";
            person.IAge = 20;

            Console.WriteLine("이름 : {0}", person.SName); 
            Console.WriteLine("나이: {0}",person.SGender);
            Console.WriteLine("성별: {0}", person.IAge);
            Console.WriteLine("주소: {0}",person.SAddress);
            Console.WriteLine("끝");

            Thread.Sleep(3000);
        }
    }
}
