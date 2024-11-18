using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManagerWin
{
    internal class Vocal : Musician
    {
        public Vocal(int imgNo, string name):base(imgNo, name) { 
        
        this.IImgNo = imgNo;
        this.sName = name;

        }


        public override string Play()
        {
            return this.sName +
                "가 연주한다. \n ~소리질러~~";

        }

    }
}
