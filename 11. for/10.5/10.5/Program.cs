using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите число:");
            double number = double.Parse(Console.ReadLine());
            double powerOf3 = 0;
            int amountPowerOf3 = 0;
            while (true)
            {
                powerOf3 = number / 3;
                amountPowerOf3 = amountPowerOf3 + 1;
                if (amountPowerOf3 == 1)
                {
                    Console.WriteLine("Данное число является степенью числа 3.");
                    break;
                }
                else
                {
                    Console.WriteLine("Данное число не является степенью числа 3.");
                }
                Console.ReadLine();
            }
        }
    }
}
