using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    class Tank
    {
        public char enemyTank = '█';
        public char tankBarrel = '|';
        public int x;
        public int y;
        static Random randomPosition = new Random();
        static Random randomDistance = new Random();
        static Random randomDirection = new Random();
        public int distance;
        public int direction;
        public Tank()
        {
            x = randomPosition.Next(0, Console.WindowWidth - 1);
            y = randomPosition.Next(1, Console.WindowHeight - 1);
            distance = randomDistance.Next(0, 12);
            direction = randomDirection.Next(1, 5);
        }

        public void DrawEnemyTank()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            EnemyTankDirects();
            Console.Write(tankBarrel);
            Console.SetCursorPosition(x, y);
            Console.Write(enemyTank);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void EnemyTankGoesUp()
        {
            for (int i = 0; i < distance; i++)
            {
                y--;
            }
        }
        public void EnemyTankGoesDown()
        {
            for (int i = 0; i < distance; i++)
            {
                y++;
            }
        }
        public void EnemyTankGoesLeft()
        {
            for (int i = 0; i < distance; i++)
            {
                x--;
            }
        }
        public void EnemyTankGoesRight()
        {
            for (int i = 0; i < distance; i++)
            {
                x++;
            }
        }

        public void EnemyTankDirects()
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
    }
}
