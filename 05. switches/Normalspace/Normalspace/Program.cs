using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Космический исследовательский ровер просит ввести некоторую информацию для определения благоприятной планеты.");
            Console.WriteLine("Пожалуйста, введите процентное содержание кислорода в воздухе данной планеты:");
            double o2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите температуру данной планеты:");
            double t = double.Parse(Console.ReadLine());
            double no2 = 20;
            double nt = 15;
            if (o2 > no2)
            {

                if (t > nt)
                {
                    Console.WriteLine("Данная планета пригодна для заселения! Высокая температура!");
                }
                else
                {
                    Console.WriteLine("Данная планета не пригодна для заселения! Низкая температура!");
                }
            }
            else
            {
                Console.WriteLine("Данная планета не пригодна для заселения!");
            }
            Console.ReadLine();
        }
    }
}
