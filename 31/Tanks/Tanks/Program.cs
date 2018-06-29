using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;


namespace Tanks
{
    class Program
    {
        static PlayerTank playerTank = new PlayerTank();
        static List<Bullet> bullets = new List<Bullet>();
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
                    bullets.Add(new Bullet(playerTank.x, playerTank.y, playerTank.direction));
                }
                if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
                {
                    playerTank.GoUp();
                }
                if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
                {
                    playerTank.GoDown();
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A)
                {
                    playerTank.GoLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D)
                {
                    playerTank.GoRight();
                }
            }
        }
        static void Update()
        {
            playerTank.Draw();
            for (int i = 0; i < bullets.Count; i++)
            {
                int dist1 = Console.WindowHeight - bullets[i].yBullet;
                if (dist1 > 1)
                {
                    bullets[i].Shoot();
                }

                else if (dist1 <= 1)
                {
                    bullets.RemoveAt(i);
                    i--;
                }

                int dist2 = Console.WindowTop - bullets[i].yBullet;
                if (dist2 < 0)
                {
                    bullets[i].Shoot();
                }

                else if (dist2 >= 0)
                {
                    bullets.RemoveAt(i);
                    i--;
                }

                int dist3 = Console.WindowLeft - bullets[i].xBullet;
                if (dist3 < 0)
                {
                    bullets[i].Shoot();
                }

                else if (dist3 >= -3)
                {
                    bullets.RemoveAt(i);
                    i--;
                }

                int dist4 = Console.WindowWidth - bullets[i].xBullet;
                if (dist4 > 1)
                {
                    bullets[i].Shoot();
                }

                else if (dist4 <= 1)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
