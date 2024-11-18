using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EncapsulationWithInheritance
{
    internal class Person
    {

        //public  string sName;
        //public string sGenger;
        //public string sAddress;
        //public int iAge;

        //private string sName;
        //private string sGenger;
        //private string sAddress;
        //private int iAge;

        protected string sName;
        protected string sGender;
        protected string sAddress;
        protected int iAge;

        public string SName { get => sName; set => sName = value; }
        public string SGenger { get => sGender; set => sGender = value; }
        public string SAddress { get => sAddress; set => sAddress = value; }
        public int IAge { get => iAge; set => iAge = value; }




        public Person()
        {

        }

        public Person(string name, string genger, string address, int age)
        {
            this.sName = name;
            this.sGender = genger;
            this.sAddress = address;
            this.iAge = age;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("이름: " + this.sName);
            Console.WriteLine("성별: " + this.sGender);
            Console.WriteLine("주소: " + this.sAddress);
            Console.WriteLine("나이: {0} ", this.iAge);

        }
    }
}
