using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bombing
{
    class Plane
    {
        public string plane = ">";
        private int speed = 2;
        public int x = 0;
        public int y = 0;
        public void Flight()
        {
            for (int i = 0; i < 10; i += speed)
            {
                Console.SetCursorPosition(i, y);
                Console.Write(plane);
            }
        }
    }
}
