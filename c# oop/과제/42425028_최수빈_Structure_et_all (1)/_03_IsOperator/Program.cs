using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMammal hodol = new Tiger();
            hodol.Walk();

            Console.WriteLine("Is hodol a Tiger? {0}", hodol is Tiger);
            Console.WriteLine("Is hodol a Cat?{0}", hodol is Cat);

            IMammal tom = new Cat();
            tom.Walk();


            Console.WriteLine("Is Tom a Tiger? {0}", tom is Tiger);
            Console.WriteLine("Is Tom a Cat? {0}", tom is Cat);

        }
    }
}
