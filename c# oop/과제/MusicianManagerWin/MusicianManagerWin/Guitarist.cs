using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManagerWin
{
    internal class Guitarist: Musician
    {
        public Guitarist(int imgNo, string name):base(imgNo, name) {
        
        this.IImgNo = imgNo;
        this.sName = name;
        
        }

        public override string Play()
        {
            return this.sName +
                "가 연주한다. \n 징징 장장 지기지기 장~~";

        }


    }
}
