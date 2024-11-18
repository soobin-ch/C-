using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_ScoreHandle
{
    internal class Student
    {

        public static int count = 0;

        private int id;
        private string name;
        private int cs;

        private int oop;
        private int html;


        public Student(int id, string name, int cs, int oop, int html)
        {
            this.id = id;
            this.name = name;
            this.cs = cs;
            this.oop = oop;
            this.html = html;
        }

        public int Id
        {
            get => this.id;
        }
        public string Name
        {
            get=> this.name;
        }
        public int Cs
        {
            get => this.cs;
        }
        public int Oop
        {
            get=>this.oop;
        }

        public int Html
        {
            get => this.html;
        }


        public static string GetGrade(int iScore)
        {
            string grade;

            if (iScore >= 95)
            {
                grade = "A+";
            } else if (iScore >= 90)
            {
                grade = "A0";
            } else if (iScore >= 85)
            {
                grade = "B+";
            } else if (iScore >= 80)
            {
                grade = "B0";
            } else if (iScore >= 75)
            {
                grade = "C+";
            } else if (iScore >= 70)
                {
                grade = "C0";
            } else if (iScore >= 65)
            {
                grade = "D+";
            } else if (iScore >= 60)
            {
                grade = "D0";
            }else
            {
                grade = "F";
            }



            return grade;
        }

        public static double GetPoint(int iScore)
        {
            double iPoint = 0;

            if (iScore >= 95)
            {
                iPoint = 4.5;
            }
            else if (iScore >= 90)
            {
                iPoint = 4.0;
            }
            else if (iScore >= 85)
            {
                iPoint = 3.5;
            }
            else if (iScore >= 80)
            {
                iPoint = 3.0;
            }
            else if (iScore >= 75)
            {
                iPoint = 2.5;
            }
            else if (iScore >= 70)
            {
                iPoint = 2.0;
            }
            else if (iScore >= 65)
            {
                iPoint = 1.5;
            }
            else if (iScore >= 60)
            {
                iPoint = 1.0;
            }
            else
            {
                iPoint = 0;
            }
            return iPoint;
        }
    }
}
