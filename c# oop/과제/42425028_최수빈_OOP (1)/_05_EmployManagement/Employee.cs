using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EmployManagement
{
    internal class Employee
    {
        private static int employNo = 0;

        public static int GetTotalNumbers()
        {
            return employNo;
        }

        private int id;
        private string name;
        private string companyName;
        private string salary;
        private string picture;

        public Employee(string name, string company, string salary, string picture)
        {

            employNo++;
            this.id  = employNo;
            this.name = name;
            this.companyName = company;
            this.salary = salary;
            this.picture = picture;
        }

        public int Id
        {
            get => this.id;

        }

        public string Name
        {
            get => this.name;
        }

        public string CompanyName
        {
            get=>this.companyName;
        }

        public string Salary
        {
            get => this.salary;
        }
        
        public string Picture
        {
            get =>this.picture;
        }















    }
}
