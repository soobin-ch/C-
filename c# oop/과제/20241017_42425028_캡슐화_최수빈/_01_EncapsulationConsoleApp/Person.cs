using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EncapsulationConsoleApp
{
    internal class Person
    {

        //public string sName;
        //public string sGender;
        //public string sAddress;
        //public int iAge;

        //protected string name;
        //protected int sGender;
        //protected int sAddress;
        //protected int iAge;

        //private string sName;
        //private string sGenger;
        //private string sAddress;
        //private string iAGe;

        private string name;
        private int age;

        public Person()
        {

        }

        public void SetValue(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void displayInfo()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }
    }
}
