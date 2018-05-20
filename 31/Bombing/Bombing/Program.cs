using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bombing
{
    class Program
    {
        static Plane plane = new Plane();
        static Bomb bomb = new Bomb();
        static void Main(string[] args)
        {
            while (true)
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update(); 
                    Thread.Sleep(100);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
               
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Update(); 
                    Thread.Sleep(100);
                }
            }
            Console.ReadLine();
        }
        static void Update()
        {
            plane.Flight();
            bomb.DropBomb();
        }
    }
}
