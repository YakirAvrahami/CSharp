using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class car
    {
        private int currentSpeed;
        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private int speedUp;
        public int SpeedUp
        {
            get { return speedUp; }
            set { speedUp = value; }
        }

        private int slowDown;
        public int SlowDown
        {
            get { return slowDown; }
            set { slowDown = value; }
        }

        private int stop=0;
        public int Stop
        {
            get { return stop; }
            set { stop = value; }
        }

        public void PrintCar()
        {
            Console.WriteLine($"CurrentSpeed= {CurrentSpeed} kmPerHour");
        }




    }
}
