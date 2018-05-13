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
        static void Main(string[] args)
        {
            while (true)
            {
                // Console.KeyAvailable становится равен тру, когда мы нажали любую клавишу.
                // так что повторяем, пока кнопка не нажата
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update(); // выполняем основные действия
                    Thread.Sleep(100);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
               
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    
                }
            }

           
            
            Console.ReadLine();
        }
        static void Update()
        {
            
            plane.Flight();
        }
    }
}
