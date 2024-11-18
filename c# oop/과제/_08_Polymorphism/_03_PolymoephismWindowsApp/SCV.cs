using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PolymoephismWindowsApp
{
    internal class SCV:Unit
    {

        public SCV()
        {
            this.imgNo = 0;
        }

        public override string Move()
        {
            return "SCV 가 이동합니다.";
        }
        public override string Attack()
        {
            return "나는 SCV, 작다고 무시하지 마라, 따꿍따꿍!";
        }
    }
}
