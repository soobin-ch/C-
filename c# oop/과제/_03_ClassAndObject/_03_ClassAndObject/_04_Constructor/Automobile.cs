using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constructor
{
    internal class Automobile
    {
        public String type;
        public int speed;

        public Automobile()
        {
            this.type = "자동차";
            this.speed = 0;

        }

        public Automobile(String type, int speed)
        {
            this.type=type;
            this.speed = speed;
        }


        public void SpeedUp(int value)
        {
            speed += value;
            if (speed > 100)
            {
                speed = 100;
            }


        }

        public void SpeedDown(int value)
        {
            speed -= value;
            if (speed < 0)
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
