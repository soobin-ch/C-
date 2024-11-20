using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PropertyForInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameCard  member1 = new NameCard();
            member1.Name = "홍길동";
            member1.Telephone = "010-1111-1111";
            Console.WriteLine("제 이름은 {0}이고, 전화번호는 {1}입니다.",member1.Name, member1.Telephone);
            Console.WriteLine("현재 생성된 객체의 수는 {0}개 입니다\n", NameCard.Cnt);

            NameCard member2 = new NameCard();

            member2.Name = "갑순이";
            member2.Telephone = "010-1111-1112";
            Console.WriteLine("제 이름은 {0}이고, 전화번호는 {1}입니다", member2.Name, member2.Telephone);
            Console.WriteLine("현재 생성된 객체의 수는 {0} 개입니다.\n", NameCard.Cnt);



        }
    }
}
