using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    class Bullet
    {
        public char bullet = 'o';
        public int xBullet;
        public int yBullet;
        public int direction;

        public Bullet(int x, int y , int direction)
        {
            xBullet = x;
            yBullet = y;
            this.direction = direction;
        }
        public Bullet()
        {

        }

        public void Shoot()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (direction == 1)
            {
                yBullet -= 2;
                Console.SetCursorPosition(xBullet, yBullet);
            }
            if (direction == 2)
            {
                yBullet += 2;
                Console.SetCursorPosition(xBullet, yBullet);
            }
            if (direction == 3)
            {
                xBullet -= 2;
                Console.SetCursorPosition(xBullet, yBullet);
            }
            if (direction == 4)
            {
                xBullet += 2;
                Console.SetCursorPosition(xBullet, yBullet);
            }
            
            Console.Write(bullet);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
