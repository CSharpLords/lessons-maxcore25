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
            Random rand = new Random();
            while (true)
            {
                int number = rand.Next(0, 100);
                Console.WriteLine("запомните число: " + number);
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("введите запомнинное число");
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("ага");
                }
                else
                {
                    Console.WriteLine("неа");
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
