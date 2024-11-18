using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Dog: Animal
    {

        public Dog(string name,string picture):base(name, picture) { 
        
            this.name = name;
            this.picture = picture;
        }
        public override string Speak()
        {
            return "woof~woof~";
        }
    }
}
