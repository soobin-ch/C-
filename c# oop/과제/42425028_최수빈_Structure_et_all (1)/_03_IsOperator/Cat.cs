using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IsOperator
{
    internal class Cat : IMammal
    {
        public void Walk()
        {
            Console.WriteLine("고양이과 동물은 걸을 수 있습니다.");
        }
    }
}
