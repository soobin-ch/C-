using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MethodOverridingWithVirtualMethod
{
    internal class Circle : Shape
    {
        public Circle() {
            Console.WriteLine("Circle(하위)클래스의 생성자 실행");
        
        }

        public override void CalculateArea()
        {
            base.CalculateArea();
            Console.WriteLine("Circle(하위)클래스의 CalculateArea() 메소드 실행");
        }
    }
}
