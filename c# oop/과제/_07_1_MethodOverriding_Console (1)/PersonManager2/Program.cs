using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요");
            string name = Console.ReadLine();
            Console.WriteLine("아이디를입력하세요");
            string id = Console.ReadLine();
            Console.WriteLine("평균학점을 입력하세요");
            string gpa = Console.ReadLine();
            Console.WriteLine("학비를 입력하세요");
            string credits = Console.ReadLine();
            Console.WriteLine("월급을 입력하세요");
            string salary = Console.ReadLine();
            Console.WriteLine("연차를 입력하세요");
            string years = Console.ReadLine();

            Person person1 = new Student(name, int.Parse(id), double.Parse(gpa), int.Parse(credits));

            person1.printInfo();
            ((Student)person1).printInfo();


            Person employee1 = new Employee(name, int.Parse(id), int.Parse(salary), int.Parse(years));

            employee1.printInfo();
            ((Employee)employee1).printInfo();

            Student student1 = new Student(name, int.Parse(id), double.Parse(gpa), int.Parse(credits));

            student1.printInfo();

            Employee employee2= new Employee(name, int.Parse(id), int.Parse(salary), int.Parse(years));

            employee2.printInfo();

        }

    }

}

