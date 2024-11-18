using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManager
{
    internal class Musician
    {

        protected string name;

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public Musician(string name)
        {
           this.name = name;
        }


        public void Introduce()
        {
            Console.WriteLine("나는야, {0}", this.name);
        }

        public virtual void Play()
        {
            Console.WriteLine("연주합니다.");
        }
    }
}
