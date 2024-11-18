using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManager
{
    internal class Pianist : Musician
    {
        public Pianist(string name):base(name)
        {
            this.name = name;
        }

      

        public override void Play()
        {
            Console.WriteLine("{0} 가 연주합니다", this.Name);
            Console.WriteLine("딩동 댕동 딩동 댕동");
        }
    }
}
