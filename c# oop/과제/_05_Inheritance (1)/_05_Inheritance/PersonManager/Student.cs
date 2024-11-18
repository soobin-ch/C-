using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    internal class Student : Person
    {
        public string sDepartment;
        public int iYears;
        public Student(string id, string name, string department, int years)
            : base(id, name)
        {
            this.sDepartment = department;
            this.iYears = years;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("학과 : {0}", this.sDepartment);
            Console.WriteLine("학번 : {0}", this.iYears);
        }
    }
}