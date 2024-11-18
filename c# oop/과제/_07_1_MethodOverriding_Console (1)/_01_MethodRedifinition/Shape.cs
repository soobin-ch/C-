using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MethodRedifinition
{
    internal class Shape
    {

        public Shape()
        {
            Console.WriteLine("shape(상위)클래스의 생성자 실행");
        }


        public void CalculateArea()
        {
            Console.WriteLine("Shape(상위)클래스의 CalculateArea()메서드 실행");
            
        }




    }
}
