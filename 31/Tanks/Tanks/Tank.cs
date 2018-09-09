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
        static Random random = new Random();
        public int speed;
        public int direction;
        private int frameAmount;
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
            if (frameAmount % 10 == 0)
            {
                Move();
            }
            if (frameAmount % 20 == 0)
            {
                speed = random.Next(0, 4);
                direction = random.Next(1, 5);
            }
            Console.ForegroundColor = ConsoleColor.Red;
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
    }
}
