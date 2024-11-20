using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PropertyApp
{
    internal class NameCard
    {

        private string name;
        private string telephone;


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
    }
}
