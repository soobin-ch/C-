using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UsingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ICar myCar;
            //myCar = new Taxi();
            //myCar.Run();

            //myCar = new Truck();
            //myCar.Run();

            //Console.WriteLine("상속받은 클래스를 이용한 객체 생성");
            //Taxi myTaxi = new Taxi();
            //myTaxi.Run();
            //Truck myTruck = new Truck();
            //myTruck.Run();  



            ICar[] Cars = new ICar[2];
            Cars[0] = new Taxi();

            foreach (var car in Cars)
            {
                car.Run();
            }
        }
    }
}
