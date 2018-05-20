using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bombing
{
    class Building
    {
        public void DrawBuilding()
        {
            Console.SetCursorPosition(5, Console.WindowHeight);
            Console.WriteLine("//\\");
            Console.SetCursorPosition(5, Console.WindowHeight);
            Console.WriteLine("|  |");
            Console.SetCursorPosition(5, Console.WindowHeight);
            Console.WriteLine("|  |");
        }
        public void DrawCottage()
        {
            Console.SetCursorPosition(8, Console.WindowHeight);
            Console.WriteLine("//\\");
            Console.SetCursorPosition(8, Console.WindowHeight);
            Console.WriteLine("|  |");
        }
    }
}
