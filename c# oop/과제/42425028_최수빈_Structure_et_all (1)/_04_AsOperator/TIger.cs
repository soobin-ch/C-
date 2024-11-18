using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AsOperator
{
    internal class TIger: Cat, IMammal
    {
        public new void Walk()
        {
            Console.WriteLine("고양이과에 속하는 호랑고양이속의 동물은 걸을 수 있습니다.");
        }
    }
}
