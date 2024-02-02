using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat instan class / object
            Time objTime = new Time();
            // memanggil method pada class tersebut
            objTime.DisplayCurrentTime();

        }
    }
}
