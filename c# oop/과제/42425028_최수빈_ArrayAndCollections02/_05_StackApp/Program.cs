using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();


            Console.WriteLine("Stack.Push() 메서드 이용 자료 입력");
            stack.Push("두원공과대학교");
            stack.Push("컴퓨터공학과");
            stack.Push("1학년");

            printStack(stack);

        }

        static void printStack(Stack stack)
        {
            Console.WriteLine("Stack.Pop() 메서드를 이용한 자료 출력");
            Console.WriteLine("myStack");
            Console.WriteLine();


            Console.WriteLine("Count :{0}", stack.Count);
            Console.WriteLine();


            Console.WriteLine("Values :");

            while (stack.Count >0)
            {
                Console.WriteLine("\t{0}", stack.Pop());
            }
        }
    }
}
