using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1_PolymorphismWithoutInheritance
{

    internal class SCV
    {
        public void Move()
        {
            Console.WriteLine("SCV가 이동합니다. 슈슈슈슝!");
        }
        public void Attack()
        {
            Console.WriteLine("나는 SCV, 작다고 무시하지마. 따꿍따꿍!\n");
        }
    }
}
