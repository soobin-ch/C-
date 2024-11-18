using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StaticMethod
{
    class InstanceCounter
    {
        private static int counter = 0;

        public static int GetCounter()
        {
            return counter;
        }
		public InstanceCounter()
		{
			counter++;
		}
		~InstanceCounter()
		{
			counter--;
		}

	}
}
