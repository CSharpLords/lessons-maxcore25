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
            int[] massive = {1, 2, 3, 3, 5, 7, 5, 3, 5};
            int sum = 0;
            for (int number = 0; number < massive.Length; number++)
            {
                if (massive[number] == 5)
                {
                    Console.WriteLine("Нашлось число в массиве с числом 5: " + number);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
