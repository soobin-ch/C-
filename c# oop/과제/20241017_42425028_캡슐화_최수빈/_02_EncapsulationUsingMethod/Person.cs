using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EncapsulationUsingMethod
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



        public void SetValue(string name, string gender, string address, int age)
        {
            this.sName = name;
            this.sGenger = gender;
            this.sAddress = address;
            this.iAge = age;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("이름: " + this.sName);
            Console.WriteLine("성별: " + this.sGenger);
            Console.WriteLine("주소: " + this.sAddress);
            Console.WriteLine("나이: {0} " , this.iAge);
        
        }
        
    }
}
