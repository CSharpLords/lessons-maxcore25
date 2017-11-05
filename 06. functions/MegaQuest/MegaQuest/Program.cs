using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Beginning();
        }
        static void ShowInvalidAlert()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введён инвалидный вариант.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        static void ShowOption(string option)
        {
            Thread.Sleep(500);
            Console.WriteLine(option);
        }
        static void Hat(string frame)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(frame);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void GameOver(string lose)
        {
            Console.WriteLine(lose);
            NewGame();
        }
        static void Beginning()
        {
            Hat("Ты - супергерой. Твоя задача - вызволить принцессу из плена Всемирной Сети, куда она попала, по неосторожности ткнув в рекламный баннер. Выбери действие:");
            Console.WriteLine();
            ShowOption("1. Поиграть в Доту");
            ShowOption("2. Узнать на каком сайте она застряла");
            int answer1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer1 == 1)
            {
                GameOver("Конец игры! Ты просидел в Доте до утра, и принцессу спас другой хакер");
            }
            else if (answer1 == 2)
            {
                WebSite();
            }
            else
            {
                ShowInvalidAlert();
            }
        }
        static void WebSite()
        {
            Hat("Оказывается, принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob.");
            Console.WriteLine();
            ShowOption("1. Послушаться совета в адресе сайта и поиграть в Доту");
            ShowOption("2. Перейти на сайт");
            ShowOption("3. Обновить антивирус, а потом перейти на сайт");
            int answer2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer2 == 1)
            {
                GameOver("Конец игры! Проигрыш - другой хакер спас принцессу");
            }
            else if (answer2 == 2)
            {
                GameOver("Конец игры! Проигрыш - игрок заразился тем же вирусом, что и принцесса, застрял на том же сайте со сломанным компьютером");

            }
            else if (answer2 == 3)
            {
                KapchaMonsterComes();
            }
            else
            {
                ShowInvalidAlert();
            }
        }
        static void KapchaMonsterComes()
        {
            Hat("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2?");
            Console.WriteLine();
            ShowOption("1. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            ShowOption("2. Проверить исходный код Капча-Монстра");
            ShowOption("3. Ответить монстру: 6");
            int answer3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer3 == 1)
            {
                GameOver("Конец игры! Проигрыш - другой хакер спас принцессу");
            }
            else if (answer3 == 2)
            {
                HackKapchaMonster();
            }
            else if (answer3 == 3)
            {
                GameOver("Конец игры! Проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2");
            }
            else
            {
                ShowInvalidAlert();
            }
        }
        static void HackKapchaMonster()
        {
            Hat("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");
            Console.WriteLine();
            ShowOption("1. Круто, пойду попробую так в своей программе!");
            ShowOption("2. Ответить монстру: 6");
            ShowOption("3. Заменить цвет всех черных символов на белый и перезагрузить Капчу-Монстра");
            int answer4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer4 == 1)
            {
                GameOver("Конец игры! Проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо");
            }
            else if (answer4 == 2)
            {
                GameOver("Конец игры! Проигрыш - зря, что ли, подвох находил??");

            }
            else if (answer4 == 3)
            {
                GiveAnswer();

            }
            else
            {
                ShowInvalidAlert();
            }

              
        }
        static void GiveAnswer()
        {
            Hat("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2) * 2?");
            Console.WriteLine();
            Thread.Sleep(500);
            ShowOption("1. Ответить монстру: 8");
            ShowOption("2. Герою лень считать, и он идет в Доту");
            int answer5 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer5 == 1)
            {
                WinKapchaMonster();
            }
            else if (answer5 == 2)
            {
                GameOver("Конец игры! Проигрыш - другой хакер спас принцессу");
            }
            else
            {
                ShowInvalidAlert();
            }

            
        }
        static void WinKapchaMonster()
        {
            Hat("Капча-Монстр обиженно сопит \"Как ты догадался? Я же спрятал скобки!\", отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:Antiviruscure.exe.");
            Console.WriteLine();
            ShowOption("1.Отправить лекарство принцессе по почте и пойти в Доту");
            ShowOption("2.Записать лекарство на флешку и пойти к принцессе домой");
            int answer6 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer6 == 1)
            {
                GameOver("Конец игры! Проигрыш - у нее сломался компьютер, она не может получить твой файл! Принцессу спасает другой хакер");
            }
            else if (answer6 == 2)
            {
                Hat("Ура!!! Победа! Ты успешно справился со всеми испытаниями и спас принцессу!");
            }
            else
            {
                ShowInvalidAlert();
            }
            Console.ReadLine(); 
        }
        static void NewGame()
        {
            Console.WriteLine("Хотите начать игру заново?");
            string YourWish = Console.ReadLine().ToLower();
            if (YourWish == "да")
            {
                Console.Clear();
                Beginning();
            }
            else if (YourWish == "нет")
            {
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
