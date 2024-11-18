using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager2
{
    internal class Employee :Person
    {
        public Employee(string name, int id, int salary, int years) :base(name,id) {
            this.salary = salary;
            this.years = years;
        }

        private int salary;
        private int years;

        public int Ssalary { get => this.salary; }
        public int Syears { get => this.years; }

        public override void printInfo()
        {

            Console.WriteLine("이름은 " + this.SName);
            Console.WriteLine("아이디는 " + this.Id);
            Console.WriteLine("월급은 " + this.Ssalary);
            Console.WriteLine("연차는 " + this.Syears);
            
        }
    }
}
