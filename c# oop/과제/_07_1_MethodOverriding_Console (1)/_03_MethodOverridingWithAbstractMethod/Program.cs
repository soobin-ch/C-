using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MethodOverridingWithAbstractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("상위 클래스(Shape) 를 이용한 객체 생성 불가");
            //Shape shape = new Shape();

            Console.WriteLine("하위 클래스(Circle) 를 이용한 객체 활용");
            Circle circle = new Circle();
            circle.CalculateArea();

            Shape mCircle2 = new Circle();
            mCircle2.CalculateArea();

        }
    }
}
