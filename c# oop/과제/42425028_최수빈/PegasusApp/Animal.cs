using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusApp
{
    internal class Animal
    {
        protected int age;
        protected string name;

        public Animal(int age, string name) {
        
            this.age = age;
            this.name = name;
        
        }

        public int Age
        {
            get => this.age;
        }
        public string Name
        {
            get=>this.name;
        }
    }
}
