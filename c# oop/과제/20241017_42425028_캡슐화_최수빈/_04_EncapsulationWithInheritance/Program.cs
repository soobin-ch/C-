using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_EncapsulationWithInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("인수 있는 생성자를 호출하여 객체 생성");
            Student student = new Student("갑순이", "여성", "서울시 종로구", 20, 41950101, "컴공");


            Console.WriteLine("객체 생성 후 , 메서드 DisplatInfo() 를 이용한 출력");
            student.DisplayInfo();

            student.SAddress = "경기도 파주시";
            student.SDepartment = "컴퓨터공학과";
            Console.WriteLine("최종 결과를 메서드 DisplayInfo()를 이용한 출력");
            student.DisplayInfo();

            Console.WriteLine("속성(prooerty)를 이용한 출력");
            Console.WriteLine("주소: " + student.SAddress);
            Console.WriteLine("학과: " + student.SDepartment);


            Thread.Sleep(10000);
        }
    }
}
