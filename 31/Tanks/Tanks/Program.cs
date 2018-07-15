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
            if (frameAmount == 100)
            {
                frameAmount = 0;
                for (int i = 0; i < 1; i++)
                {
                    enemyTanks.Add(new Tank());
                    enemyTanks[i].DrawEnemyTank();



                    for (int j = 0; j < bullets.Count; j++)
                    {
                        if (bullets[j].yBullet <= Console.WindowTop - 2)
                        {
                            bullets.RemoveAt(j);
                            j--;
                        }
                        if (bullets[j].yBullet >= Console.WindowHeight + 2)
                        {
                            bullets.RemoveAt(j);
                            j--;
                        }
                        if (bullets[j].yBullet > 0 && bullets[j].yBullet < Console.WindowHeight && bullets[j].xBullet > 0 && bullets[j].xBullet < Console.WindowWidth)
                        {
                            bullets[j].Shoot();
                        }
                        if (bullets[j].xBullet <= Console.WindowLeft + 2)
                        {
                            bullets.RemoveAt(j);
                            j--;
                        }
                        if (bullets[j].xBullet >= Console.WindowWidth - 2)
                        {
                            bullets.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
            frameAmount += 2;
        }
    }
}
