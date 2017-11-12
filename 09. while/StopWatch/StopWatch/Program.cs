using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0;
            while (true)
            {
                sec = sec + 1;
                Console.WriteLine(sec);
                Thread.Sleep(1);
            }
        }
    }
}
