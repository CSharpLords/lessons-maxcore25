using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks
{
    class Tank
    {
        public string tank = "0";
        public int x;
        public int y;
        public void DrawTank()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tank + "|");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
