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
            int[] massive = { 12, 24, 44, 50, 100 };
            int sum = 0;
            for (int number = 0; number < massive.Length; number++)
            {
                sum = sum + massive[number];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
