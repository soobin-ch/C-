using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMath
{
    internal static class Math
    {
        public const double PI = 3.1415926535897931;
       public static  int rst = 1;

        public static double Abs(double x)
        {
            if(x > 0)
            {
                return x;
            }else
            {
                return -x;
            }
        }

        public static int Abs(int x)
        {
            if(x > 0)
            {
                return x;
            }else
            {
                return -x;
            }
        }

        public static double Max(double x, double y)
        {
            if(x > y)
            {
                return x;
            }else
            {
                return y;
            }
        }

        public static int Max(int x, int y)
        {
            if(x > y)
            {
                return x;
            }else
            {
                return y;
            }
        }

        public static double Min(double x, double y)
        {
            if(x > y)
            {

                return y;
            }else
            {
                return x;
            }
        }

        public static int Min(int x, int y )
        {
            if (x > y)
            {
                return y;
            }else
            {
                return x;
            }
        }

        public static int Pow(int x, int y )
        {
           
            for( int i =1; i<=y; i++ )
            {
                rst = rst * x; 

            }
            return rst;
        }

    }
}
