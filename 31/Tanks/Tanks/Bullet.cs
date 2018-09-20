﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    class Bullet
    {
        public char bullet = 'o';
        public int x;
        public int y;
        public int direction;

        public Bullet(int x, int y , int direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }
        public Bullet()
        {

        }

        public void Fly()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (direction == 1)
            {
                y -= 2;
                Console.SetCursorPosition(x, y);
            }
            if (direction == 2)
            {
                y += 2;
                Console.SetCursorPosition(x, y);
            }
            if (direction == 3)
            {
                x -= 2;
                Console.SetCursorPosition(x, y);
            }
            if (direction == 4)
            {
                x += 2;
                Console.SetCursorPosition(x, y);
            }
            
            Console.Write(bullet);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
