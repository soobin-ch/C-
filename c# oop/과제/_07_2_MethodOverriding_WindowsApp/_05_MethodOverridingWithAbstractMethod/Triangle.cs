using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MethodOverridingWithAbstractMethod
{
    internal class Triangle : Shape
    {
        public Triangle(string type, double width, double height) : base(type, width, height)
        {
        }

        public override void CalculateArea()
        {
            this.dArea = this.dWidth * this.dHeight / 2;

        }
    }
}
