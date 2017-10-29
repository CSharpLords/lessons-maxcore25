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
            Console.WriteLine("Здравствуйте! Пожалуйста, введите отрицательное/положительное число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите ещё одно отрицательное/положительное число:");
            int b = int.Parse(Console.ReadLine());
            comparison(a, b);
        }
        static void comparison(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("+");
            }
            Console.ReadLine();
        }
    }
}
