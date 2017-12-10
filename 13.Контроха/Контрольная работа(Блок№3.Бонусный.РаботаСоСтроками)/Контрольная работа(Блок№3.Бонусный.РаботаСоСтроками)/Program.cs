using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Контрольная_работа_Блок_3.Бонусный.РаботаСоСтроками_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Василий, загадывай слово:");
            string VasyaWord = Console.ReadLine().ToLower();
            Console.WriteLine("Валера, введи букву:");
            char ValeraLetter = char.Parse(Console.ReadLine().ToLower()); 
            int correct = 0;
            int Number = 0;            
            int attempt = 5;
            while (attempt > 0) 
            {
               Console.WriteLine("Валера, вводи символы по порядку:");
               char letter = char.Parse(Console.ReadLine().ToLower());
               char Char = VasyaWord[Number];
               if (letter != Char)
               {
                    Console.WriteLine("Буква не верна!");
                    attempt = attempt - 1;
                    Console.WriteLine("Осталось:" + attempt + " попыток(ки)");
               }
               else if (letter == Char) 
               {
                    Console.WriteLine("Молодец,Буква верна!!!");
                    Number = Number + 1;
                    attempt++;
                    if (attempt == VasyaWord.Length) 
                    {
                       Console.WriteLine();
                        Console.WriteLine("Молодец,ты угадал всё слово!!!");
                        break;
                    }
                }

            }
            Console.ReadLine();
            
        }
    }
}
