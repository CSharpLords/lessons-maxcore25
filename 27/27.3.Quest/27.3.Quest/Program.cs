using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27._3.Quest
{
    class Program
    {
        static double maxHP = 100;
        static double HP = 50;
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Приветствую тебя, додик, в моей 'Недоигре'!");
            Console.WriteLine("Выбери одно действие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Теперь ты в лесу торчков! Тут много закладок и рынков с нелегальными товарами! Но также здесь есть разбойники-торчки, которым нужна очередная доза мета, чтобы выжить и получить кайф!");
            Console.WriteLine("Перед тобой висит указатель с психоделическими рисунками Фрейда. Выбери, куда пойти:");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Поздравляю! Ты нашёл тряпку, которая сгодится для брони!");
                Console.WriteLine("Теперь уровень жизни: 250");
                Forest();
            }
            if(item == 1)
            {
                maxDMG = 100;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Поздравляю! Ты нашёл ядовитый шприц от герыча!");
                Console.WriteLine("Теперь уровень атаки: 100");
                Forest();
            }
            
        }
        static void FightRobbers()
        {
            RobbersAttack();
            
            if(robbersHP > 0)
            {
                if(maxHP > 0)
                {
                    AskQuestion();
                    HeroAttack();
                }
                
                else if(maxHP <= 0)
                {
                    
                    
                    Console.WriteLine("Тебе кинули в лицо серную кислоту! Ты сдох!");
                    End();
                }
            }
                    
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ты втыкаешь шприц в шею одному разбойнику, делаешь сальтуху и втыкаешь в вену другому! Они умерают от передозировки!");
                End();
            }
                    
            
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double healthProportion = maxHealth / health;
            double attackProportion = maxAttack / healthProportion;
            return attackProportion;
        }
        static void AskQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выбери дейтсвие:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Атаковать");
            Console.WriteLine("2.Убежать в Зелёные поля");
            int answerQuestion = int.Parse(Console.ReadLine());
            
            if(answerQuestion == 1)
            {
                HeroAttack();
                FightRobbers();
            }
            else if(answerQuestion == 2)
            {
                Greenfields();
            }
        }
        static void HeroAttack()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ты атакуешь!"); 
            robbersHP = robbersHP - DMG; 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Хп этих торчков: " + robbersHP);
        }
        static void RobbersAttack()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Разбойники атакуют!");
            maxHP = maxHP - robbersDMG;  
            robbersDMG = GetReducedAttack(HP, maxHP, robbersDMG);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Твоё хп: " + maxHP); 
        }
        static void End()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выбери желание:");
            Console.WriteLine("1.Выйти из игры, т.к. я уже задолбался");
            Console.WriteLine("2.Начать сначала, т.к. это самая лучшая игра");
            int lastAnswer = int.Parse(Console.ReadLine());
            if(lastAnswer == 1)
            {
                Environment.Exit(0);
            }
            else if(lastAnswer == 2)
            {
                Reset();
                Greenfields();
            }
        }
        static void Reset()
        {
            maxHP = 100;
            HP = 50;
            maxDMG = 50;
            DMG = 50;
            robbersHP = 200;
            robbersDMG = 100;
        }
    }
}
