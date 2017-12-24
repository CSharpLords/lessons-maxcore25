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
            int[] array = {1, 2, 4, 5, 6, 7, 8, 10};
            for (int num = 0; num < array.Length; num++)
            {
                double result = array[num] % 2;
                if (result == 0)
                {
                    Console.WriteLine(array[num]);
                }
            }
            Console.ReadLine();
        }
    }
}
