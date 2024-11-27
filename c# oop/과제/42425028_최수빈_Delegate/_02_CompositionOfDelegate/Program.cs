using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CompositionOfDelegate
{
    internal class Program
    {

        public delegate void stuff();

        public static void Sugar()
        {
            Console.WriteLine("설탕을 넣습니다.");

        }
        public static void Cream()
        {
            Console.WriteLine("크림을 넣습니다.");
        }
        public static void Milk()
        {
            Console.WriteLine("우유를 넣습니다.");
        }
        public static void Coffee()
        {
            Console.WriteLine("커피를 넣습니다.");
           
        }
        static void Main(string[]  args)
        {
            stuff s = new stuff(Sugar);
            stuff C = new stuff(Cream);
            stuff M = Milk;
            stuff Cafe = Coffee;

            Console.WriteLine("===비엔나 커피 만들기===");
            stuff vienna = Cafe + C + s;
            vienna();
            Console.WriteLine();

            Console.WriteLine("===까뻬오레 만들기===");
            stuff CafeAulait = Cafe + M + s;
            CafeAulait();
            Console.WriteLine();

            Console.WriteLine("===블랙커피 만들기===");
            stuff blackCoffee = CafeAulait - M - s;
            blackCoffee();

        }
    }
}
