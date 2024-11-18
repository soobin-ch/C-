using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PolymoephismWindowsApp
{
    internal class Unit
    {

        protected int imgNo;
        protected bool mode;


        public int ImgNo
        {
            get => this.imgNo;
            set => this.imgNo = value;

        }

        public bool Mode
        {
            set => this.mode = value;
        }

        public virtual string Move()
        {
            return "이동한다";
        }
        public virtual string Attack()
        {
            return "공격한다";
        }
    }
}
