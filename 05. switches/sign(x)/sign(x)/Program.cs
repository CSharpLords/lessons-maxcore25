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
            Console.WriteLine("sign(x) = 1,   если x > 0.");
            Console.WriteLine("sign(x) = -1,   если x < 0.");
            Console.WriteLine("sign(x) = 0,   если x = 0.");
            double x = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("sign(x) = 1");
            }
            else if (x < 0)
            {
                Console.WriteLine("sign(x) = -1");
            }
            else if (x == 0)
            {
                Console.WriteLine("sign(x) = 0");
            }
            Console.ReadLine();
        }
    }
}
