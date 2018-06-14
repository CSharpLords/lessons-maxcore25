using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Tanks
{
    class Program
    {
        static PlayerTank playerTank = new PlayerTank();
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
                if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
                {
                    playerTank.GoUp();
                }
                if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
                {
                    playerTank.GoDown();
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A)
                {
                    playerTank.GoLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D)
                {
                    playerTank.GoRight();
                }
            }
        }
        static void Update()
        {
            playerTank.Draw();
        }
    }
}
