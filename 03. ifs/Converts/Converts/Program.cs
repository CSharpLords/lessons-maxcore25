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
            Console.WriteLine("Input distance in cm");
            double cms = int.Parse(Console.ReadLine());
            double meters = (double)cms / 100;
            Console.WriteLine("metres =" + meters);
            Console.ReadLine();

        }
    }
}
