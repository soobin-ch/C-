using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    internal class Employee : Person
    {
        public string sDivision;
        public int iSalary;
        public Employee(string id, string name, string division, int salary)
            : base(id, name)
        {
            this.sDivision = division;
            this.iSalary = salary;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("학과 : {0}", this.sDivision);
            Console.WriteLine("봉급 : {0}", this.iSalary);
        }
    }
}
