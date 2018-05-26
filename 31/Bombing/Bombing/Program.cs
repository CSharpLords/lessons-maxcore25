﻿using System;
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
        //static Bomb bomb = new Bomb();
        //static Building building = new Building();
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
                int dist = buildings[i].xBuilding - xBomb;
            
                if (dist <= 4 && dist >= 0)
                {
                    buildings.Remove(buildings[i]);
                }
                if (dist >= -4 && dist <= 0)
                {
                    buildings.Remove(buildings[i]);
                }
            }
            for (int i = 0; i < cottages.Count; i++)
            {
                int dist = cottages[i].xBuilding - xBomb;
            
                if (dist <= 4 && dist >= 0)
                {
                    buildings.Remove(cottages[i]);
                }
                if (dist >= -4 && dist <= 0)
                {
                    buildings.Remove(cottages[i]);
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
