using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MethodOverridingWithAbstractMethod
{
    abstract class Shape
    {

        protected string sType;
        protected double dWidth;
        protected double dHeight;
        protected double dArea;


        public string SType { get => this.sType; }
        public double DWidth { get => this.dWidth; }
        public double DHeight { get => this.dHeight; }
        public double DArea { get => this.dArea; }


        public Shape()
        {

        }


        public Shape(string type)
        {
            this.sType = type;
        }
        public Shape(string type, double dWidth, double dHeight)
        {
            this.sType = type;
            this.dWidth = dWidth;
            this.dHeight = dHeight;
        }


        public abstract void CalculateArea();
    }
}
