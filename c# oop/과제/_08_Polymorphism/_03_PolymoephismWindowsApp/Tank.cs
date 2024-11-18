using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PolymoephismWindowsApp
{
    internal class Tank : Unit
    {
        public Tank() {

            this.imgNo = 2;
            this.mode = false;

        }

        public void ChangeMode()
        {
            if (this.mode) this.imgNo = 2;
            else this.imgNo = 3;

            this.mode = !this.mode;
        }

        public override string Move()
        {
            return " 탱크 부대 전진!";
        }

        public override string Attack()
        {
            if (this.mode) return "시즈 모드탱크의 강력한 공격...펑!";
            else
            {
                return "일반 탱크라고 얏보지마!";
            }
        
        }


    }
}
