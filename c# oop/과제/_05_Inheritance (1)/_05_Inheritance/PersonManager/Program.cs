using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("42425028", "최수빈", "컴퓨터소프트웨어과", 24);
            myStudent.DisplayInfo();

            Employee myEmployee = new Employee("01010101", "김영우교수님", "컴퓨터소프트웨어과", 1000);
            myEmployee.DisplayInfo();
        }
    }
}
