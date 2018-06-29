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
        static List<Building> cottages = new List<Building>();
        static void Main(string[] args)
        {
            buildings.Add(new Building(10));
            buildings.Add(new Building(30));
            cottages.Add(new Building(45));
            cottages.Add(new Building(50));
            cottages.Add(new Building(55));
            
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
                    Destruction(bombs[i].xBomb);
                    bombs.RemoveAt(i);
                    i--;  
                }
            }
        }
        static void Destruction(int xBomb)
        {
            for (int i = 0; i < buildings.Count; i++)
            {
                int distBuilding = buildings[i].xBuilding - xBomb;
                
                if (distBuilding <= 4 && distBuilding >= 0)
                {
                    buildings.Remove(buildings[i]);
                    i--;
                }
                else if (distBuilding >= -4 && distBuilding <= 0)
                {
                    buildings.Remove(buildings[i]);
                    i--;
                }
                
            }
            for (int i = 0; i < cottages.Count; i++)
            {
                int distCottage = cottages[i].xBuilding - xBomb;
                if (distCottage <= 4 && distCottage >= 0)
                {
                    cottages.Remove(cottages[i]);
                    i--;
                }
                else if (distCottage >= -4 && distCottage <= 0)
                {
                    cottages.Remove(cottages[i]);
                    i--;
                }
            }
        }
        static void DrawBuildings()
        {
            for (int i = 0; i < buildings.Count; i++)
            {
                buildings[i].DrawBuilding();
                
            }
            for (int i = 0; i < cottages.Count; i++)
            {
                
                cottages[i].DrawCottage();
            }
        }
    }
}
