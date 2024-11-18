using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManagerWin
{
    internal class Drummer: Musician
    {
        public Drummer(int imgNo, string name):base(imgNo, name) { 
        
            this.IImgNo = imgNo;
            this.sName = name;
        
        }


        public override string Play()
        {
            return this.sName +
                "가 연주한다. \n 쿵쿵 딱딱 쿵쿵 따~~"; 
        }
    }
}
