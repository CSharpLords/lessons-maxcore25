using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите свой возраст:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10 && age < 20)
            {
                Console.WriteLine("Поздравляю! Ты подросток!");
      
            }
            else
            {
                Console.WriteLine("К сожалению, ты - не подросток.");
            }
            Console.ReadLine();
        }
    }
}

