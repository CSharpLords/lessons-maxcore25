using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber + "^" + secondNumber + "=" + Power(firstNumber, secondNumber));
            Console.ReadLine();
        }

        static int Power(int number, int exponent)
        {
            int result = number;
            for (int n = 1; n < exponent; n++ )
            {
                result = result * number;
            }
            
            return result;
        }
    }
}