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
            Console.WriteLine("Здравствуйте! Пожалуйста, введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите первое число:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите первое число:");
            double c = double.Parse(Console.ReadLine());
            if (a == b || a == c || c == b)
                Console.WriteLine("Hельзя определить наименьшее/наибольшее");
            else
            {
                Console.WriteLine("Наименьшее число " + Math.Min(a, Math.Min(b, c)));
                Console.WriteLine("Наибольшее число " + Math.Max(a, Math.Max(b, c)));
            }

            Console.ReadLine();
        }
    }
}
