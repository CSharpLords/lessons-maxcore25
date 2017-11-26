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
            int time = 0;
            while (time < 10)
            {
                Thread.Sleep(1000);
                time = time + 1;
                Console.WriteLine(time);
            }
            Console.ReadLine();
        }
    }
}
