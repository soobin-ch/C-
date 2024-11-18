using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Alien: Animal
    {
        public Alien(string name, string picture):base(name,picture) {
        
            this.name = name;
            this.picture = picture; 
        }

       
    }
}
