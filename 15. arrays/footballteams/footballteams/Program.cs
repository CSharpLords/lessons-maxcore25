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
            int[] massive = { 1, 2, 4, 5, 6, 7, 8, 9, 0 };
            for (int number = 0; number < massive.Length; number++)
            {
                if (massive[number] < 3)
                {
                    Console.WriteLine("У команды: " + number + " меньше 3 побед");
                }
            }
            Console.ReadLine();
        }
    }
}
