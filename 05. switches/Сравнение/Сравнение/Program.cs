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
            Console.WriteLine("input a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("input c:");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("max is " + a);
                }
                else
                {
                    Console.WriteLine("max is " + c);
                }
            }
            else
            {
                if (b > c)
                {
                Console.WriteLine("max is " + b );
                }
                else
                { 
                Console.WriteLine("max is " + c);
                }
            }
            Console.ReadLine();
        }
    }
}
