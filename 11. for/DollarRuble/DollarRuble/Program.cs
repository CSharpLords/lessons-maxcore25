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
            for (int dollar = 0; dollar < 21; dollar = dollar + 1)
            {
                int ruble = dollar * 60;
                Console.WriteLine(dollar + " dollars = " + ruble + " rubles.");
            }
            Console.ReadLine();
        }
    }
}
