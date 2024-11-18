using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MethodOverridingWithVirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("상위 클래스(Shape)를 이용한 객체 활용");
            Shape shape = new Shape();
            shape.CalculateArea();

            Console.WriteLine("\n하위클래스(Circle) 를 이용한 객체 활용");
            Circle circle = new Circle();
            circle.CalculateArea();


            Console.WriteLine("\n상위클래스 레퍼런스변수, 하위클래스 인스턴스 생성");
            Shape mCircle = new Circle();

            mCircle.CalculateArea();



        }
    }
}
