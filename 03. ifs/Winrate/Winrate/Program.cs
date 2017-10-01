using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравстуйте! Сколько игр Вы успели сыграть?");
            int games = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько игр Вы выиграли?");
            int wongames = int.Parse(Console.ReadLine());
            double winrate = (double)wongames / games;
            Console.WriteLine("Ваш винрейт составляет: " + winrate);
            Console.ReadLine();


        }
    }
}
