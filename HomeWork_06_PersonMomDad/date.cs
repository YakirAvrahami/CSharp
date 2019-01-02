using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1
{

    class date
    {
        private int day;
        public int Day
        {
            get { return day; }
            set {
                if (value > 0 && value <= 31)
                    day = value;
            }
        }

        private int month;
        public int Month
        {
            get { return month; }
            set {
                if (value >= 1 && value <= 12)
                    month = value;
            }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public date()
        {

        }

        public string toString_Date()
        {
            return $"the date is: {Day}/{Month}/{Year}";
        }

    }
}
