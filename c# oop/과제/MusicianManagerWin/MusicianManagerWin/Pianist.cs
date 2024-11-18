using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManagerWin
{
    internal class Pianist : Musician
    {
     
        public Pianist(int imgNo, string name):base(imgNo,name)
        {
            this.iImgNo = imgNo;
            this.sName = name;
        }

        public override string Play()
        {
            return this.sName + 
                "가 연주한다. \n 딩동 댕동 딩동 댕동~~";

        }


    }
}
