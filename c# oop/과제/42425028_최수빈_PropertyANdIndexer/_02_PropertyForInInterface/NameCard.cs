using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PropertyForInInterface
{
    internal class NameCard :INameCard
    {

        private string name;
        private string telephone;


        private static int count = 0;


        public NameCard() {
          
            
            count++;

          }

        public string Name
        {
            get => this.name;
            set => this.name = value;   
        }

        public string Telephone
        {
            get => this.telephone;
            set => this.telephone = value;
        }

        public static int Cnt 
        {
            get => count;
        }
    }
}
