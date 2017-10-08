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
            Console.WriteLine("Приветствую тебя, начинающий рыцарь! Настало время победить дракона!Ты можешь его одолеть только если он молодой или сильно ранен!");
            Console.WriteLine("Введи возраст дракона:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи количество хп дракона:");
            int hp = int.Parse(Console.ReadLine());
            int old = 150;
            int fullhp = 100;
            if (age < old)
            {
                Console.WriteLine("Дракон ещё молодой! Атакуй!");
            }
            else
            {
                if (hp < fullhp)
                {
                    Console.WriteLine("Нападай!");
                }
            }
            Console.ReadLine();
        }
    }
}
