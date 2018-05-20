using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bombing
{
    class Plane
    {
        public string plane = ">";
        public static int x = 0;
        public void Flight()
        {
            int endBorder = Console.WindowWidth;
            x += 3;
            if (endBorder < x)
            {
                x = 0;
            }
            Console.SetCursorPosition(x, 0);
            Console.WriteLine(plane);
        }
    }
}
