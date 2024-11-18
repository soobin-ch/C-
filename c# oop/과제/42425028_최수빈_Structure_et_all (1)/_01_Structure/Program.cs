using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(10, 10);
            Console.WriteLine("점 pt1==> x좌표: {0}, y좌표 : {1}", pt1.x, pt1.y);


            Point pt2;

            pt2.x = 20;
            pt2.y = 40;

            Console.WriteLine("점 pt2 --> x 좌표: {0}, y좌표: {1}", pt2.x, pt2.y);



        }
    }
}
