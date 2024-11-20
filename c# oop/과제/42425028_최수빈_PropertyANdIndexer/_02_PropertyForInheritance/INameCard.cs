using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PropertyForInheritance
{
    internal interface INameCard
    {
        string Name
        {
            get;
            set;
        }
        string Telephone
        {
            get;
            set;
        }
    }
}
