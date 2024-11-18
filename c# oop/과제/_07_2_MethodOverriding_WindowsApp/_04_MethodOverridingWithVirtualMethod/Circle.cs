using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _04_MethodOverridingWithVirtualMethod
{
    internal class Circle : Shape
    {

        private double dRadius;
        private const double D_PI = 3.14;


        public double DRadius { get => this.dRadius; }


        public Circle(string type, double radius) : base(type)
        {
            this.dRadius = radius;
        }

        public override void CalculateArea()
        {
            this.dArea = D_PI * this.dRadius * this.dRadius;

        }
    }
}
