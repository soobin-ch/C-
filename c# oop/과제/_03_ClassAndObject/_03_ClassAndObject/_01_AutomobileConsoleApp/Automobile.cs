using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AutomobileConsoleApp
{
    internal class Automobile
    {

        public String type;
        public int speed;
        
        public void SpeedUp(int value)
        {
            speed += value;
            if(speed > 100)
            {
                speed = 100;
            }


        }

        public void SpeedDown(int value)
        {
            speed -= value;
            if(speed < 0 )
            {
                speed = 0;
            }

        }

        public void Stop()
        {
            speed = 0;
        }
    }
}
