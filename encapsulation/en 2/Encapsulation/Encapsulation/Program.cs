using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Time objTime = new Time();
            //memberi nilai property
            objTime.Year = 2009;
            objTime.Month = 5;
            objTime.Date = 1;
            //mengambil nilai dengan property
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date); 
        }
    }
}
