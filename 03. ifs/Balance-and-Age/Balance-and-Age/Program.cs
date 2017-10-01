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
            Console.WriteLine("Input balance");
            int balance = int.Parse(Console.ReadLine());
            int price = 45;
            int discount = 10;
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age < 15)
            {
                price = price - discount;
                price = price - 13;

            }
            else
            {
                price = price + 5;
            }
            Console.WriteLine("остаток = " + (balance - price));
            Console.ReadLine();
        }
    }
}
