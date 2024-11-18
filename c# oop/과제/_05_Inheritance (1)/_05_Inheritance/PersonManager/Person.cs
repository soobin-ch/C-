using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    internal class Person
    {
        public string sId;
        public string sName;
        public Person(string id, string name)
        {
            this.sId = id;
            this.sName = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("아이디 : {0}", this.sId);
            Console.WriteLine("이름 : {0}", this.sName);
        }
    }
}