using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Animal
    {
        protected string name;
        protected string picture = "";

        
        public Animal(string name, string picture) 
        {
            this.name = name;
            this.picture = picture;

        }

        public string SName { get=>this.name;}
        public string SPicture { get=>this.picture;}    

        public virtual string  Speak()
        {
            return "i don't know!";
        }


    }
}
