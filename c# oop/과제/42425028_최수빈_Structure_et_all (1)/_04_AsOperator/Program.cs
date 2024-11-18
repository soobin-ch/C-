using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _04_AsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMammal hodol = new TIger();
            hodol.Walk();

            Object obj = hodol as Cat;

            if( obj != null)
            {
                Console.Write("{0}은 고양이의 일종이라구\n." , obj);

            }else
            {
                Console.WriteLine("나는 고양이가 아니라구\n");
            }

             IMammal tom = new Cat();

            tom.Walk();
            obj = tom as TIger;
            if( obj != null)
            {
                Console.WriteLine("{0}은 호랑이의 일종이라우\n", obj);
            }else
            {
                Console.WriteLine("나는 호랑이가 아니라우\n");
            }
        }
    }
}
