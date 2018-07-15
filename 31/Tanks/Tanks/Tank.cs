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
        static Random rand = new Random();
        public Tank()
        {
            x = rand.Next(0, Console.WindowWidth - 1);
            y = rand.Next(1, Console.WindowHeight - 1);
        }
        public void DrawEnemyTank()
        {
           
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write(enemyTank);
            Console.SetCursorPosition(x, y - 1);
            Console.Write(tankBarrel);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
