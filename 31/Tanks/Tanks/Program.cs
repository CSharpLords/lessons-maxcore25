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
            for (int i = 0; i < 2; i++)
			{
                enemyTanks.Add(new Tank());
                Thread.Sleep(6000);
			    enemyTanks.Add(new Tank());
                enemyTanks[i].DrawEnemyTank();
			}
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].yBullet <= Console.WindowTop - 2)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
                if (bullets[i].yBullet >= Console.WindowHeight + 2)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
                if (bullets[i].yBullet > 0 && bullets[i].yBullet < Console.WindowHeight && bullets[i].xBullet > 0 && bullets[i].xBullet < Console.WindowWidth)
                {
                    bullets[i].Shoot();
                }
                if (bullets[i].xBullet <= Console.WindowLeft + 2)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
                if (bullets[i].xBullet >= Console.WindowWidth - 2)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
            }

        }
    }
}
