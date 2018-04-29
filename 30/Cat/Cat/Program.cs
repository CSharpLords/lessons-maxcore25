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
            Cat cat = new Cat();
            cat.Meow();
            cat.Walk();
            
            Console.ReadLine();
        }
    }
}
