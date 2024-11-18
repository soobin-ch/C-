using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MethodRedifinition
{
    internal class Circle : Shape
    {
        public Circle() {

            Console.WriteLine("Circle(하위)클래스의 생성자 실행");

        } 


        public new void CalculateArea()
        {
            Console.WriteLine("Circle(하위)클래스의 CalculateArea() 매서드 실행");
        }


    }
}
