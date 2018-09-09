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
        static List<Tank> enemyTanks = new List<Tank>();
        static int frameAmount = 100;
        static void Main(string[] args)
        {
            Console.Title = "Tanks";
            while (true)
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update();
                    Thread.Sleep(50);
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
            if (frameAmount == 100)
            {
                frameAmount = 0;
                enemyTanks.Add(new Tank());

            }
            for (int i = 0; i < enemyTanks.Count; i++)
            {
                enemyTanks[i].Draw();
            }

            for (int j = 0; j < bullets.Count; j++)
            {
                bullets[j].Fly();
                for (int i = 0; i < enemyTanks.Count; i++)
                {
                    if (bullets[j].x == enemyTanks[i].x && bullets[j].y == enemyTanks[i].y)
                    {
                        bullets.RemoveAt(j);
                        j--;
                        enemyTanks.RemoveAt(i);
                        i--;
                        break;
                    }
                }  
            }
            frameAmount += 1;
            CheckBorders();
        }
        private static void CheckBorders()
        {
            for (int j = 0; j < bullets.Count; j++)
            {
                if (bullets[j].y <= Console.WindowTop + 1)
                {
                    bullets.RemoveAt(j);
                    j--;
                    continue;
                }
                if (bullets[j].y >= Console.WindowHeight - 1)
                {
                    bullets.RemoveAt(j);
                    j--;
                    continue;
                }
                if (bullets[j].x <= Console.WindowLeft + 1)
                {
                    bullets.RemoveAt(j);
                    j--;
                    continue;
                }
                if (bullets[j].x >= Console.WindowWidth - 1)
                {
                    bullets.RemoveAt(j);
                    j--;
                    continue;
                }
            }
        }
    }
}
