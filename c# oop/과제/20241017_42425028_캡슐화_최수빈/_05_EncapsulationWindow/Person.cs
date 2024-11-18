using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EncapsulationWindow
{
    internal class Person
    {

        protected string sName;
        protected string sGender;
        protected string sAddress;
        protected int iAge;
        protected string sPicture;


        public Person() { }


        public Person(string name, string gender, string address, int age, string picture)
        {
            this.sName = name;
            this.sGender = gender;
            this.sAddress = address;    
            this.sPicture = picture;
            this.iAge = age;
        }


        public string SName { get => sName; /*set => sName = value; */ }
        
        public string SGender { get => sGender; /*set => sGender = value;*/ }
       
        public string SAddress { get => sAddress; set => sAddress = value; }
        public int IAge {    get => iAge; set => iAge = value;  }

        public string SPicture { get => sPicture; set => sPicture = value; }


    }
}
