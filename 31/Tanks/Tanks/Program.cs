using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tanks
{
    //https://github.com/CSharpWizards/homework_w-pchuck77/tree/master/13
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update(); 
                    Thread.Sleep(100);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    
                }
            }
        }
        static void Update()
        {

        }
    }
}
