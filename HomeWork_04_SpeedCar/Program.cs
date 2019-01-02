using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.CurrentSpeed = 100;
            car1.PrintCar();

            Console.Write("how much do you want to speed up: "  );
            car1.SpeedUp= Convert.ToInt32( Console.ReadLine() );
            car1.CurrentSpeed += car1.SpeedUp;
            car1.PrintCar();

            car1.SlowDown = 2;
            car1.CurrentSpeed -= car1.SlowDown;
            car1.PrintCar();

            car1.CurrentSpeed = car1.Stop;
            car1.PrintCar();
                                 
        }
    }
}
