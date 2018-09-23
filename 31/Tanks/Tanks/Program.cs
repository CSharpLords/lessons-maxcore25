using System;
using System.Collections.Generic;
using System.Threading;


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
            CheckBordersForBullets();
            CheckHit();
        }
        private static void CheckBordersForBullets()
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
        private static void CheckHit()
        {
            CheckBorders();
            for (int i = 0; i < Tank.bullets.Count; i++)
            {
                Tank.bullets[i].Fly();
                if (Tank.bullets[i].x == playerTank.x && Tank.bullets[i].y == playerTank.y)
                {
                    Tank.bullets.RemoveAt(i);
                    i--;
                    FinishHim();
                    break;
                }
            }
        }
        private static void CheckBorders()
        {
            for (int j = 0; j < Tank.bullets.Count; j++)
            {
                if (Tank.bullets[j].y <= Console.WindowTop + 1)
                {
                    Tank.bullets.RemoveAt(j);
                    j--;
                    continue;
                }
                if (Tank.bullets[j].y >= Console.WindowHeight - 1)
                {
                    Tank.bullets.RemoveAt(j);
                    j--;
                    continue;
                }
                if (Tank.bullets[j].x <= Console.WindowLeft + 1)
                {
                    Tank.bullets.RemoveAt(j);
                    j--;
                    continue;
                }
                if (Tank.bullets[j].x >= Console.WindowWidth - 1)
                {
                    Tank.bullets.RemoveAt(j);
                    j--;
                    continue;
                }
            }
        }
        private static void FinishHim()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.Write("GAME ");
            Thread.Sleep(1000);
            Console.WriteLine("OVER");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1);
            Console.WriteLine("Press R to restart");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 3);
            string restarting = Console.ReadLine().ToLower();
            if (restarting == "r")
            {
                playerTank = new PlayerTank();
                bullets.Clear();
                enemyTanks.Clear();
                frameAmount = 0;
                Tank.bullets.Clear();
            }
            else
            {
                Console.Clear();
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("Please, press R to restart");
                Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 2 + 3);
                restarting = Console.ReadLine().ToLower();
                if (restarting == "r")
                {
                    playerTank = new PlayerTank();
                    bullets.Clear();
                    enemyTanks.Clear();
                    frameAmount = 0;
                    Tank.bullets.Clear();
                }
            }
        }
    }
}
