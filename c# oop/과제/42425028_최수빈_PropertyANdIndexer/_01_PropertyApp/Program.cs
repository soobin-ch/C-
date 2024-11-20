using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PropertyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NameCard me = new NameCard();
            me.Name = "홍길동";
            me.Telephone = "010-1111-1111";


            Console.WriteLine("제 이름은 {0} 이고, 전화번호는 {1}입키다.\n",me.Name, me.Telephone);

            me.Name = "갑순이";
            me.Telephone = "010-1111-1112";
            Console.WriteLine("제 이름은 {0} 이고, 전화번호는 {1} 입니다.\n", me.Name, me.Telephone);


        }
    }
}
