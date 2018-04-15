using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27._3.Quest
{
    class Program
    {
        static double maxHP = 100;
        static double HP = 100;
        static double maxDMG = 50;
        static double DMG = 50;
        static double robbersHP = 200;
        static double robbersDMG = 100;
        static void Main(string[] args)
        {
            Greenfields();
            Console.ReadKey();
            
        }
        static void Greenfields()
        {
            Console.WriteLine("Приветствую тебя, додик, в моей 'Недоигре'!");
            Console.WriteLine("Выбери одно действие:");
            Console.WriteLine("1.Перейти в лес");
            Console.WriteLine("2.Oсмотреть поле");
            int answer1 = int.Parse(Console.ReadLine());
            if(answer1 == 1)
            {
                Forest();
            }
            else if(answer1 == 2)
            {
                WatchGreenfields();
            }
        }
        static void Forest()
        {
            Console.WriteLine("Теперь ты в лесу торчков! Тут много закладок и рынков с нелегальными товарами! Но также здесь есть разбойники-торчки, которым нужна очередная доза мета, чтобы выжить и получить кайф!");
            Console.WriteLine("Перед тобой висит указатель с психоделическими рисунками Фрейда. Выбери, куда пойти:");
            Console.WriteLine("1.Перейти на Зеленые поля");
            Console.WriteLine("2.Атаковать разбойников-торчков");
            int answer2 = int.Parse(Console.ReadLine());
            if(answer2 == 1)
            {
                Greenfields();
            }
            if (answer2 == 2)
            {
                FightRobbers();
            }
        }
        static void WatchGreenfields()
        {
            Random rand = new Random();
            int item = rand.Next(0, 2);
            if (item == 0)
            {
                maxHP = 250;

                Console.WriteLine("Поздравляю! Ты нашёл тряпку, которая сгодится для брони!");
                Console.WriteLine("Теперь уровень жизни: 250");
                Forest();
            }
            if(item == 1)
            {
                maxDMG = 100;

                Console.WriteLine("Поздравляю! Ты нашёл ядовитый шприц от герыча!");
                Console.WriteLine("Теперь уровень атаки: 100");
                Forest();
            }
            
        }
        static void FightRobbers()
        {
            
                Console.WriteLine("Разбойники атакуют!");
                maxHP = maxHP - robbersDMG; // =250 - 100 
                Console.WriteLine("Твоё хп: " + HP); // 150
                robbersDMG = GetReducedAttack(HP, maxHP, robbersDMG);
                
                if(DMG == 50 || maxDMG == 50)
                {
                    Console.WriteLine("Ты бьёшь рукой!"); 
                    robbersHP = robbersHP - DMG; // 200 - 50
                    Console.WriteLine("Хп этих торчков: " + robbersHP); // = 150
                }
                
                else if(DMG  >= 20)
                {
                    Console.WriteLine("Ты втыкаешь шприц в шею одному разбойнику, делаешь сальтуху и втыкаешь в вену другому! Они умерают от передозировки!");
                
                }
                
                else if(maxHP <= 0)
                {
                    Console.WriteLine("Тебе кинули в лицо серную кислоту! Ты сдох!");
                }
            
            
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double healthProportion = maxHealth / health;
            double attackProportion = maxAttack / healthProportion;
            return attackProportion;
        }
        
    }
}
