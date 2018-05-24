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
        static List<Building> buildings = new List<Building>();
        //static Bomb bomb = new Bomb();
        //static Building building = new Building();
        static void Main(string[] args)
        {
            buildings.Add(new Building(10));
            buildings.Add(new Building(20));
            
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
            DrawBuildings();
            plane.Flight();
            for (int i = 0; i < bombs.Count; i++)
            {
                int dist = Console.WindowHeight - bombs[i].y;
                if (dist > 1)
                {
                    bombs[i].Fall();
                }
                
                if (dist <= 2)
                {
                    bombs[i].Explosion();
                    bombs.RemoveAt(i);
                    Destruction();
                    i--;  
                }
            }
        }
        static void Destruction()
        {
            int dist = xBuilding - xBomb;
            
            if (dist <= 1 || dist <= 1)
            {
                buildings.RemoveAt(0);
            }
        }
        static void DrawBuildings()
        {
            for (int i = 0; i < buildings.Count; i++)
            {
                buildings[i].DrawBuilding();
                buildings[i].DrawCottage();
            }//&& dist >= 0
        }
    }
}
