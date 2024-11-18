using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08_1_PolymorphismWithoutInheritance

{
    internal class Program
    {
        static void Main(string[] args)
        {
            SCV mySCV = new SCV();
            mySCV.Move();
            mySCV.Attack();

            Console.WriteLine();
            Marine marine = new Marine();
           marine.Move();
            marine.Attack();


            Console.WriteLine();
            Tank myTank = new Tank();
            myTank.Mode = true;
            myTank.Move();
            myTank.Attack();

            Console.WriteLine();
            myTank.Mode = false;
            myTank.Move();
            myTank.Attack();


        }
    }
}

