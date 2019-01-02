using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock=new Clock(19,26,30,1234);             //setting clock
            myClock.Show();

            myClock.Milliseconds = myClock.Milliseconds + 2;    //promote the clock in 2 millisec
            myClock.Show();

            myClock.SetMidDay();
            myClock.Milliseconds+=3;                            //another way to promote
            myClock.Show();

            Clock yourClock;                                    //another way to setting clock
            yourClock = new Clock();
            yourClock.SetMidNight();
            yourClock.Show();
                                          
        }
    }
}
