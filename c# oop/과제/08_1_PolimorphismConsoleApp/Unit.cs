using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PolymorphismWithInheritance
{
    internal class Unit
    {

        public virtual void Move()
        {
            Console.WriteLine("이동한다");
        }

        public virtual void Attack() {

            Console.WriteLine("공격한다");
                }
    }
}
