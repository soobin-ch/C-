using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManagerWin
{
    internal class Musician
    {
        protected int iImgNo;
        protected string sName;

        public int IImgNo
        {
            get => this.iImgNo;
            set => this.iImgNo = value;

        }


        public Musician(int imgNo, string  name)
        {
            this.sName = name;
            this.iImgNo = imgNo;
        }

        public string introduce()
        {
            return "나는야 " + this.sName + "!";
        }

        public virtual string Play()
        {
            return "연주한다";
        }


    }
}
