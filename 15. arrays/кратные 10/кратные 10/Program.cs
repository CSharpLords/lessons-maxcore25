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
            int[] array = {1, 10, 30, 3, 2, 20};
            for (int num = 0; num < array.Length; num++)
            {
                double result = array[num] % 10;
                if (result == 0)
                {
                    Console.WriteLine(array[num]);
                }
            }
            Console.ReadLine();
        }
    }
}
