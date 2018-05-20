using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bombing
{
    class Bomb
    {
        public string bomb = "0";
        static int y = 0;
        
        public void DropBomb()
        {
            int xBomb = Plane.x;
            int groundBorder = Console.WindowHeight;
            y += 1;

            List<string> bombs = new List<string>();
            bombs.Add(bomb);
            
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                Console.SetCursorPosition(xBomb, y);
                Console.WriteLine(bomb);
            }
            
            if (groundBorder < y)
            {
                bombs.Remove(bomb);
                Explosion();
                Thread.Sleep(100);
                Console.Clear();
                y = 0;
            }
            
        }
        public void Explosion()
        {
            int groundBorder = Console.WindowHeight;
            Console.SetCursorPosition(groundBorder, y);

            Console.WriteLine("˄ ▓▒▓ /");

            Console.WriteLine("[ ▓▓▓▒");
  
            Console.WriteLine("██▓▓▓▒█ █▒▓");
        }
        
    }
}
