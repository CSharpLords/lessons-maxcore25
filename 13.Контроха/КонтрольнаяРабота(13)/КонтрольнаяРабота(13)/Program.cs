using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace КонтрольнаяРабота_13_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! У тебя есть компуктер?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "нет")
            {
                Console.WriteLine("Ну ок, тогда нам не о чем говорить. Пока!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (answer == "да")
            {
                Console.WriteLine("Сколько часов в неделю ты проводишь за ним?");
            }
            int time = int.Parse(Console.ReadLine());
            if (time < 14)
            {
                Console.WriteLine("А большую часть этого времени ты работаешь или отдыхаешь?");
                string answer1 = Console.ReadLine().ToLower();
                if (answer1 == "работаю")
                {
                    Console.WriteLine("Ты и отдохнуть не забывай!");
                }
                else if (answer1 == "отдыхаю")
                {
                    Console.WriteLine("Хорошо, что ты знаешь меру");
                }
            }
            else if (time > 14)
            {
                Console.WriteLine("А большую часть этого времени ты работаешь или отдыхаешь?");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "работаю")
                {
                    Console.WriteLine("Пожалей себя!!");
                }
                else if (answer2 == "отдыхаю")
                {
                    Console.WriteLine("Ты портишь свое здоровье таким поведением!");
                }
            }
            Console.ReadLine();
        }
    }
}
