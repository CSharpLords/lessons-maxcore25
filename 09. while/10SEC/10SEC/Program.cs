using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch();
            
        }

        static void StopWatch()
        {
            int sec = 0;
            while (true)
            {
                sec = sec + 1;
                Console.WriteLine(sec);
                Thread.Sleep(1000);
                if (sec == 10)
                {
                    
                    Environment.Exit(0);
                }
            }
            Console.ReadLine();
        }
    }
}
