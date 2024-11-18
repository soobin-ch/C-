using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musician pianist = new Pianist("피아니스트");
            pianist.Introduce();
            pianist.Play();

            Console.WriteLine("\n");

            Musician guitarist = new Guitarist("기타리스트");
            guitarist.Introduce();
            guitarist.Play();
            Console.WriteLine("\n");
            Musician drummer = new Drummer("드러머");
            drummer.Introduce();
            drummer.Play();
            Console.WriteLine("\n");
            Musician vocal = new Vocal("보컬");
            vocal.Introduce();
           vocal.Play();



        }
    }
}
