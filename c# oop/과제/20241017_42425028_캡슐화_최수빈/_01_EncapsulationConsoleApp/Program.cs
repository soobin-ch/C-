using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_EncapsulationConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person mPerson = new Person();
            mPerson.SetValue("홍길동", 20);

            mPerson.displayInfo();


           
         
        }
    }
}
