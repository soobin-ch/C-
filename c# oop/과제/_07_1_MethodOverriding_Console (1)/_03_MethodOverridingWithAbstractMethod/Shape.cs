using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MethodOverridingWithAbstractMethod
{
    abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape(상위)클래스의 생성자 실행");
        }

        public abstract void CalculateArea();
    }
}
