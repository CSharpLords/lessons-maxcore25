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
            DrawBuilding(x);
            //DrawCottage(x + 20);
        }
        public Building()
        {
        }
        public void DrawBuilding(int x)
        {
            Console.SetCursorPosition(x, Console.WindowHeight - 4);
            Console.WriteLine("//\\");
            Console.SetCursorPosition(x, Console.WindowHeight - 3);
            Console.WriteLine("|| |");
            Console.SetCursorPosition(x, Console.WindowHeight - 2);
            Console.WriteLine("||_|");
            
        }
        public void DrawCottage(int x)
        {
            Console.SetCursorPosition(x, Console.WindowHeight - 3);
            Console.WriteLine("//\\");
            Console.SetCursorPosition(x, Console.WindowHeight - 2);
            Console.WriteLine("||_|");
        }
    }
}
