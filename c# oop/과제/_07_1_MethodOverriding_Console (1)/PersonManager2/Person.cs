using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager2
{
    abstract class Person
    {
        protected string name;
        protected int id;

        public Person()
        {

        }

        public string SName { get => this.name; }
        public int Id { get => this.id; }


        public Person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public abstract void printInfo();
    }
}
