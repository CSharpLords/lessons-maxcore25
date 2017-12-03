using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 10; number < 26; number = number + 1)
            {
                double a = .4;
                Console.WriteLine(number + " " + (number + a));
            }
            Console.ReadLine();
        }
    }
}
