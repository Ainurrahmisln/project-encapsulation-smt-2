using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Time
    {
        // private variables atau field
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;
        // property
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        // public methods
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu sekarang : {0}", DateTime.Now.ToString());
        }
    }
}
