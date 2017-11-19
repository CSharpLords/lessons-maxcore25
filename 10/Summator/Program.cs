using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summator
{
    class Program
    {
        static void Main(string[] args) 
        {
            int sum = 0;
            while (true) 
            {   
                Console.WriteLine("Введите число:");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                Console.WriteLine("Сумма всех чисел: " + sum);
                Console.WriteLine();
            }
        }
    }
}
