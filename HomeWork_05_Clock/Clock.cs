using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    class Clock
    {
        private int hours;
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        private int minutes;
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        private int milliseconds;
        public int Milliseconds
        {
            get { return milliseconds; }
            set { milliseconds = value; }
        }

        public void Tick()
        {
            milliseconds = milliseconds + 1000;
            seconds = seconds + 1;
            minutes = minutes + seconds / 60;
            hours = hours + minutes / 60;
            milliseconds = milliseconds % 60;
            seconds = seconds % 60;
            minutes = minutes % 60;
            hours = hours % 24;
        }

        public void Show()
        {
            Console.WriteLine($"The current time is:\t{Hours}:{Minutes}:{Seconds}.{Milliseconds}");
        }

        public void SetMidNight()
        {
            milliseconds = 0;
            seconds = 0;
            minutes = 0;
            hours = 0;
        }

        public void SetMidDay()
        {
            milliseconds = 0;
            seconds = 0;
            minutes = 0;
            hours = 12;
        }

        public Clock(int hours,int minutes,int seconds,int milliseconds)
        {
            Milliseconds = milliseconds;
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        public Clock()
        {

        }

    }
}
