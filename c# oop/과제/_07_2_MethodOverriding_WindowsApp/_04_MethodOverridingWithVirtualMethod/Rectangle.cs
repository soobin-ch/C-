using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MethodOverridingWithVirtualMethod
{
    internal class Rectangle : Shape
    {
        public Rectangle(string type, double width, double height): base(type, width, height)
        {
        }
    }
}
