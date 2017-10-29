using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите первое целое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int b = int.Parse(Console.ReadLine());
            comparison(a, b);
        }
        static void comparison(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a == b)
            {
                Console.WriteLine("=");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            Console.ReadLine();
        }
    }
}
