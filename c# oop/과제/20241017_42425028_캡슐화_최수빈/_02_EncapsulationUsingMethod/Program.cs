using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_EncapsulationUsingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person();
            //person.SetValue("홍길순", "여성", "경기도 고양시", 20);

            Person person = new Person("갑돌이", "남성", "서울시 마포구", 20);


            Thread.Sleep(3000);

            person.DisplayInfo();
            Thread.Sleep(10000);

        }
    }
}
