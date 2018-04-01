using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairSymbol
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckPairs("namespace ConsoleApplication1 {class Program {static void Main(string[] args) {}", "{", "}");
            CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", "(", ")");
            Console.ReadLine();
        }
        static void CheckPairs(string text, string openSymbols, string closeSymbols)
        {
            int amountOpenSymbols = 0;
            int amountCloseSymbols = 0;
            for (int n = 0; n < text.Length; n++)
            {
                if (openSymbols == text[n].ToString())
                {
                    amountOpenSymbols = amountOpenSymbols + 1;
                }
                if (closeSymbols == text[n].ToString())
                {
                    amountCloseSymbols = amountCloseSymbols + 1;
                }
            }
            if (amountCloseSymbols == amountOpenSymbols)
            {
                Console.WriteLine("Все в порядке");
            }
            else
            {
                Console.WriteLine("Найдены ошибки");
            }
        }
    }
}
