using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03__EncapsulationUsingProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("갑순이","여성","서울시 종로구", 20);
            Console.WriteLine("객체 생성후 , 메서드 DisplayInfo()를 이용한 출력");
            person.DisplayInfo();
            
            person.SAddress = "경기도 파주시";
            person.IAge = 21;

            Console.WriteLine("property를 이용한 출력");
            Console.WriteLine("이름: " + person.SName);
            Console.WriteLine("주소: " + person.SAddress);
            //Console.WriteLine("나이: {0}",person.IAge );
            Console.WriteLine("속성 수정후, 메서드 DisplayInfo()를 이용한 출력");
            person.DisplayInfo();

           

        }
    }
}
