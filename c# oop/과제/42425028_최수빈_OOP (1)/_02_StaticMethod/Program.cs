using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InstanceCounter ic1, ic2;
            Console.WriteLine("인스턴스 갯수:{0}", InstanceCounter.GetCounter());

            ic1 = new InstanceCounter();
            Console.WriteLine("인스턴스 갯수:{0}", InstanceCounter.GetCounter());

            ic2 = new InstanceCounter();
            Console.WriteLine("인스턴스 갯수:{0}", InstanceCounter.GetCounter());

            ic1 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("인스턴스 갯수:{0}", InstanceCounter.GetCounter());



            ic2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();  
            Console.WriteLine("인스턴스 갯수:{0}", InstanceCounter.GetCounter());
        }
    }
}
