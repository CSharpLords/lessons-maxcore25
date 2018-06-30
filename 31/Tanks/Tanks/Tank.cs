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
        public void DrawEnemyTank()
        {
            Random rand = new Random();
            int randX = rand.Next(0, Console.WindowWidth);
            int randY = rand.Next(0, Console.WindowHeight);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(randX, randY);
            Console.Write(enemyTank);
            Console.SetCursorPosition(randX, randY - 1);
            Console.Write(tankBarrel);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
