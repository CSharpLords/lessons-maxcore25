using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Legs
    {
        public int speed = 10;
        public int power = 10;
        public void Move()
        {
            Console.WriteLine("leg is moving");
            Console.WriteLine("Speed is: " + speed);
        }
    }
}
