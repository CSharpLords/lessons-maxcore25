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
        static List<Bomb> bombs = new List<Bomb>();
        static Building building = new Building();
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
                    bombs.Add(new Bomb(plane.x));
                }
            }
        }
        static void Update()
        {
            building.DrawBuilding();
            building.DrawCottage();
            plane.Flight();
            for (int i = 0; i < bombs.Count; i++)
            {
                bombs[i].Fall();
                if (Console.WindowHeight <= bombs[i].y)
                {
                    bombs[i].Explosion();
                    bombs.RemoveAt(i);
                    i--;
                }
                
            }

        }
        static void Dustraction()
        {
            
        }
    }
}
