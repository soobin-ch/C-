using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MultiInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("팀의 색깔을 입력하시오.");
            string color = Console.ReadLine();
            Console.WriteLine("팀의 생명력을 입력하시오...");
            int life = int.Parse(Console.ReadLine());

            Console.WriteLine();
            SCV myScv = new SCV();
            myScv.Color = color;
            myScv.Life = life;
            Console.WriteLine("나는 야 {0}색 SCV, 생명력은 {1}",myScv.Color, myScv.Life);
            myScv.Move();
            myScv.Attack();

        
        }
    }
}
