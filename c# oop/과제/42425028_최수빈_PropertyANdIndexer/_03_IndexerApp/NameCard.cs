using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IndexerApp
{
    internal class NameCard
    {
        private string[] names;
        public NameCard(int iMax)
        {
            names = new string[iMax];   
        }

        public string this[int index]
        {
            get
            {
                if (names[index] == null)
                    return "저장된 값이 없습니다.";
                else 
                    return this.names[index];
            }
            set
            {
                if (value == null)
                    Console.WriteLine("null값으로 지정할 수없습니다.");
                else 
                    this.names[index] = value;
            }
        }
    }
}
