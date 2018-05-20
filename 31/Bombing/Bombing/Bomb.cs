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
        public int y = 0;
        public int xBomb;
        public Bomb(int x)
        {
            xBomb = x;
        }
        public Bomb()
        {
            
        }
        public void Fall()
        {
            y += 2;
            Console.SetCursorPosition(xBomb, y);
            Console.WriteLine(bomb);
            Console.WriteLine(xBomb);
        }
        public void Explosion()
        {
            Console.SetCursorPosition(xBomb, Console.WindowHeight + 2);

            Console.WriteLine("██▓▓▓▒█");
            Console.SetCursorPosition(xBomb, Console.WindowHeight + 1);

            Console.WriteLine("[ ▓▓▓▒");
            Console.SetCursorPosition(xBomb, Console.WindowHeight);

            Console.WriteLine("˄ ▓▒▓ /");
        }

    }
}
