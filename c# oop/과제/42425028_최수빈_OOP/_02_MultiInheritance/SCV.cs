using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MultiInheritance
{
    internal class SCV: Unit, IAttackable, IMovable
    {
        public void Attack()
        {
            Console.WriteLine("SCV 가 공격합니다. 따꿍따꿍!");
        }
        public void Move()
        {
            Console.WriteLine("SCV가 이동합니다. 슈슈슈슝!");
        }
    }
}
