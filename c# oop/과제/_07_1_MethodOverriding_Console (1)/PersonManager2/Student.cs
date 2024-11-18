using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager2
{
    internal class Student : Person
    {
        public Student(string name, int id, double gpa, int credits ) :base(name, id ) {
            this.gpa = gpa;
            this.credits = credits;

        }

        private double gpa;
        private int credits;

        public double Sgpa { get => this.gpa; }
        public int Scredits { get => this.credits; }


        public override void printInfo()
        {
            Console.WriteLine("이름은 " + this.SName);
            Console.WriteLine("아이디는 " + this.Id);
            Console.WriteLine("평균학점은 " + this.Sgpa);
            Console.WriteLine("학비는 " + this.Scredits);


        }
    }
}
