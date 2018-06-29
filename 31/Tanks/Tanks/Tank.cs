using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    class Tank
    {
        public char enemyTank = '█';
        public int x;
        public int y;
        public void DrawTank()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(enemyTank + "|");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
