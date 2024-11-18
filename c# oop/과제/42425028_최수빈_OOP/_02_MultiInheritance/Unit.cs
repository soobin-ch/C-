using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MultiInheritance
{
    internal class Unit
    {

        protected int life;
        protected string color;

        public int Life
        {
            get => this.life;
            set => this.life = value;

        }

        public string Color
        {
            get => this.color;
            set => this.color = value;
        }
    }
}
