using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bombing
{
    class Building
    {
        public int xBuilding;
        public Building(int x)
        {
            xBuilding = x;
            
            //DrawCottage(xBuilding + 20);
        }
        public Building()
        {

        }
        public void DrawBuilding()
        {
            Console.SetCursorPosition(xBuilding, Console.WindowHeight - 3);
            Console.WriteLine("//\\");
            Console.SetCursorPosition(xBuilding, Console.WindowHeight - 2);
            Console.WriteLine("|| |");
            Console.SetCursorPosition(xBuilding, Console.WindowHeight - 1);
            Console.WriteLine("||_|");
            
        }
        public void DrawCottage()
        {
            Console.SetCursorPosition(xBuilding + 20, Console.WindowHeight - 2);
            Console.WriteLine("//\\");
            Console.SetCursorPosition(xBuilding + 20, Console.WindowHeight - 1);
            Console.WriteLine("||_|");
        }
    }
}
