using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusApp
{
    internal class Pegasus : Animal, Bird, Horse 
    {
        public Pegasus(int age, string name) : base(age, name) { 
        
            this.age= age;
            this.name= name;

        }

        public void Fly()
        {
            Console.WriteLine("{0} 살 {1} 가 납니다", this.age, this.name);
        }

        public void Run()
        {
            Console.WriteLine("{0} 살 {1} 가 달립니다", this.age, this.name);
        }
    }
}
