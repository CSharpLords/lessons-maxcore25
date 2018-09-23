﻿using System;

namespace Tanks
{
    class PlayerTank
    {
        public char tank = '█';
        public char tankBarrel = '|';
        public int x = Console.WindowWidth / 2;
        public int y = Console.WindowHeight / 2 ;
        public int direction = 1;

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (direction == 1)
            {
                Console.SetCursorPosition(x, y - 1);
            }
            if (direction == 2)
            {
                Console.SetCursorPosition(x, y + 1); 
            }
            if (direction == 3)
            {
                Console.SetCursorPosition(x - 1, y);
            }
            if (direction == 4)
            {
                Console.SetCursorPosition(x + 1, y);
            }
            Console.Write(tankBarrel);
            Console.SetCursorPosition(x, y);
            Console.Write(tank);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void GoUp()
        {
            direction = 1;
            y--;
            tankBarrel ='|';
            if (y <= 0)
            {
                y = Console.WindowHeight - 1;
            } 
        }
        public void GoDown()
        {
            direction = 2;
            y++;
            tankBarrel = '|';
            if (y >= Console.WindowHeight - 1)
            {
                y = 0;
            } 
        }
        public void GoLeft()
        {
            direction = 3;
            x--;
            tankBarrel = '-';
            if (x <= 0)
            {
                x = Console.WindowWidth - 1;
            } 
        }
        public void GoRight()
        {
            direction = 4;
            x++;
            tankBarrel = '-';
            if (x >= Console.WindowWidth - 1)
            {
                x = 0;
            } 
        }
    }
}
