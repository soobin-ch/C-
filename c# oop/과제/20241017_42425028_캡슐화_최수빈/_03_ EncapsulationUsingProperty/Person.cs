using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _03__EncapsulationUsingProperty
{
    internal class Person
    {
        private string sName;
        private string sGenger;
        private string sAddress;
        private int iAge;

        public Person()
        {

        }

        public Person(string name, string genger, string address, int age)
        {
            this.sName = name;
            this.sGenger = genger;
            this.sAddress = address;
            this.iAge = age;
        }

        public string SName { get => sName; /*set => sName = value;*/ }
        public string SAddress { get => sAddress; set => sAddress = value; }
        public int IAge {/*get => iAge;*/ set => iAge = value; }



        //public string  SName
        // {
        //     get
        //     {
        //         return this.sName;
        //     }
        // }

        // public string SAddress
        // {
        //     get
        //     {
        //         return this.sAddress;
        //     }
        //     set
        //     {
        //         this.sAddress = value;
        //     }
        // }

        // public int IAge
        // {
        //     set
        //     {
        //         this.iAge = value;
        //     }
        // }

        public void DisplayInfo()
        {
            Console.WriteLine("이름: " + this.sName);
            Console.WriteLine("성별: " + this.sGenger);
            Console.WriteLine("주소: " + this.sAddress);
            Console.WriteLine("나이: {0} ", this.iAge);

        }
    }
}
