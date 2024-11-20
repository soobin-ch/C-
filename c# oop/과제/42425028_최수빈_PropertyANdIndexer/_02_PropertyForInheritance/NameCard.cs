using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PropertyForInheritance
{
    internal class NameCard: INameCard
    {
        private string name;
        private string telephone;

        private static int cnt = 0;

        public NameCard()
        {
            cnt++;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public string Telephone
        {
            get => this.Telephone;
            set => this.telephone = value;
        }

        public static int Cnt
        {
            get => cnt;
        }
    }
}
