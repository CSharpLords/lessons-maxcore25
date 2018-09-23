using System;
using System.Collections.Generic;

namespace Tanks
{
    class Tank
    {
        public char enemyTank = '█';
        public char tankBarrel = '|';
        public int x;
        public int y;
        static Random random = new Random();
        public int speed;
        public int direction;
        private int frameAmount;
        public static List<Bullet> bullets = new List<Bullet>();
        public Tank()
        {
            x = random.Next(0, Console.WindowWidth - 1);
            y = random.Next(1, Console.WindowHeight - 1);
            speed = random.Next(0, 4);
            direction = random.Next(1, 5);
        }

        public void Draw()
        {
            frameAmount++;

            Console.ForegroundColor = ConsoleColor.Red;
            if (frameAmount % 10 == 0)
            {
                Move();
            }
            if (frameAmount % 20 == 0)
            {
                speed = random.Next(0, 4);
                direction = random.Next(1, 5);
            }
            if (frameAmount % 30 == 0)
            {
                Shoot();
            }
            CheckBordersForEnemyTanks();
            Align();
            Console.Write(tankBarrel);
            Console.SetCursorPosition(x, y);
            Console.Write(enemyTank);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void GoUp()
        {
            for (int i = 0; i < speed; i++)
            {
                y--;
            }
        }
        public void GoDown()
        {
            for (int i = 0; i < speed; i++)
            {
                y++;
            }
        }
        public void GoLeft()
        {
            for (int i = 0; i < speed; i++)
            {
                x--;
            }
        }
        public void GoRight()
        {
            for (int i = 0; i < speed; i++)
            {
                x++;
            }
        }

        public void Align()
        {
            if (direction == 1)
            {
                Console.SetCursorPosition(x, y - 1);
                tankBarrel = '|';
            }
            if (direction == 2)
            {
                Console.SetCursorPosition(x, y + 1);
                tankBarrel = '|';
            }
            if (direction == 3)
            {
                Console.SetCursorPosition(x - 1, y); 
                tankBarrel = '-';
            }
            if (direction == 4)
            {
                Console.SetCursorPosition(x + 1, y);
                tankBarrel = '-';
            }
        }
        public void Move()
        {
            
            if (direction == 1)
            {
                GoUp();
            }
            if (direction == 2)
            {
                GoDown();
            }
            if (direction == 3)
            {
                GoLeft();
            }
            if (direction == 4)
            {
                GoRight(); 
            }
        }
        public void CheckBordersForEnemyTanks()
        {
            if (y <= 0) 
            {
                y = Console.WindowHeight - 2;
            }

            if (y >= Console.WindowHeight - 1)
            {
                y = 1;
            }

            if (x <= 0)
            {
                x = Console.WindowWidth - 2;
            }

            if (x >= Console.WindowWidth - 1)
            {
                x = 1;
            }

        }
        public void Shoot()
        {
            bullets.Add(new Bullet(x, y, direction));
        }
    }
}
