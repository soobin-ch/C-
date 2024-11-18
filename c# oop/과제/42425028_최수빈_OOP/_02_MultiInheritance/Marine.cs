using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MultiInheritance
{
    internal class Marine: Unit, IAttackable, IMovable
    {
        public void Attack()
        {
            Console.WriteLine("머린이 공격합니다. 두두두두두....");
        }
        public void Move()
        {
            Console.WriteLine("머린이 이동합니다. 고고고고....");
        }
    }
}
