﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManager
{
    internal class Guitarist : Musician
    {
        public Guitarist(string name) :base(name) { 
        
        this.name = name;
        }

        public override void Play()
        {
            Console.WriteLine("{0} 가 연주합니다", this.Name);
            Console.WriteLine("징징 장장 지기지기 장~~");
        }

    }
}
