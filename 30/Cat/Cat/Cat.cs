using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cat
    {
        public int hp = 9;
        public Legs[] legs = new Legs[4];
        public Cat()
        {
            for (int i = 0; i < legs.Length; i++)
            {
                legs[i] = new Legs();
            }
        }
        public void Meow()
        {
            Console.WriteLine("meow");
        }
        public void Walk()
        {
            for (int i = 0; i < legs.Length; i++)
            {
                legs[i].Move();
            }
            Console.WriteLine("walk");
        }
        
    }
}
