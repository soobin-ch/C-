using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EncapsulationWithInheritance
{
    internal class Student :Person
    {
        //public int iStudentId;
        //public string sDepartment;

        private int iStudentId;
        private string sDepartment;


        public int IStudentId { get => iStudentId; set => iStudentId = value; }
        public string SDepartment { get => sDepartment; set=> sDepartment = value; }


        public Student(string name, string gender,string address, int age, int sId, string dept)
        :base (name, gender,address, age){


            this.iStudentId = sId;
            this.sDepartment = dept;

        }

      

        public new void DisplayInfo()
        {
           
           base.DisplayInfo();


        

            Console.WriteLine("학번:{0}", this.iStudentId);
            Console.WriteLine("학과:{0}",this.sDepartment);

        }
    }
    
}
