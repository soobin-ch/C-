using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MethodRedifinition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("상위 클래스(shape)를 이용한 객체 활용");
            //Shape shape = new Shape();
            //shape.CalculationArea();

            //Console.WriteLine("\n하위 클래스(Circle)를 이용한 객체 활용");
            //Circle circle = new Circle();
            //circle.CalculationArea();

            Shape mCirlce = new Circle();
            mCirlce.CalculateArea();
            ((Circle)mCirlce).CalculateArea();
        }
    }
}
