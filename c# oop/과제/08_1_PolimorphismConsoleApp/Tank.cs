using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1_PolymorphismWithoutInheritance
{
    internal class Tank
    {
        private bool mode = false;

        public bool Mode {
            get => this.mode;

            set
            {
                if (value) Console.WriteLine("탱크,시즈 모드로 전환!");
                else Console.WriteLine("탱크, 일반 모드로 전환!");

                this.mode = value;

            }
        }

        public void Move()
        {
            Console.WriteLine("탱크부대, 전진! 위잉, 철컥, 두두두둥!");

        }

        public void Attack() {

            if (this.mode) Console.WriteLine("시즈모드 탱크의 강력한 공격...펑!...펑!");
            else
                Console.WriteLine("일반 탱크라고 얏보지 마! 통....통....통...통");

        }
    }
}
  
