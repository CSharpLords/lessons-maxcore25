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
            for (int anotherNumber = 1; anotherNumber < 10; anotherNumber = anotherNumber + 1)
            {
                int multiplication = anotherNumber * 7;
                Console.WriteLine(anotherNumber + " * 7 = " + multiplication);

                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
