﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StaticMember
{
    internal class InstanceCounter
    {
        public static int counter = 0;

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
