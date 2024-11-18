using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MethodOverridingWithVirtualMethod
{
    internal class Triangle: Shape
    {
        public Triangle(string type, double width, double height) :base(type, width, height) 
        {
        }

        public override void CalculateArea()
        {
            base.CalculateArea();
            this.dArea /= 2;

        }

    }
}
