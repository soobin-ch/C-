using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PolymoephismWindowsApp
{
    internal class Marine: Unit
    {

        public Marine() {

            this.imgNo = 1;
        
        }

        public override string Move()
        {
            return " 머린이 이동합니다";
        }
        public override string Attack()
        {
            return " 나는 머린, 모두덤벼";
        }
    }
}
