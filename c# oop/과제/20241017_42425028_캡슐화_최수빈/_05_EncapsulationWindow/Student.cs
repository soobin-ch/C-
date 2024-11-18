using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EncapsulationWindow
{
    internal class Student :Person

    {
        private int iStudentId;
        private string sDepartment;
        private int iAcquiredCredits;

        public Student(string name, string gender,string address,int age, string picture, int sId,string dept,int credits)
        : base(name,gender,address,age,picture)
        {
            this.iStudentId = sId;
            this.sDepartment = dept;
            this.iAcquiredCredits = credits;
        }


        public int ISTudentId { get => iStudentId; /*set => IStudentId = value;*/ }
        public string SDepartment { get => sDepartment; /*set=> SDepartment = value;*/ }

        public int IAcquiredCredits { get=>iAcquiredCredits; set=> iAcquiredCredits = value; }
    }

}
