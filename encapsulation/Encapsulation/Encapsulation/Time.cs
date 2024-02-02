using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Time
    {
        // private variables atau field
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;
        // public methods
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu sekarang : {0}", DateTime.Now.ToString());
        }

    }
}
