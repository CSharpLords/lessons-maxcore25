using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace КонтрольнаяРабота_2.Валерка_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Валерка! Какую вещь ты хочешь найти?");
            Console.WriteLine("- носки");
            Console.WriteLine("- портфель");
            Console.WriteLine("- тапочки");
            Console.WriteLine("- XBox");
            Console.WriteLine("- телефон");
            Console.WriteLine("- записка с паролем от Dota2");
            string thing = Console.ReadLine().ToLower();
            if (thing == "носки")
            {
                Console.WriteLine("В твоей комнате. Под кроватью.");
            }
            else if (thing == "портфель")
            {
                Console.WriteLine("В гостинной. Около дивана.");
            }
            else if (thing == "тапочки")
            {
                Console.WriteLine("В ванной. Около толчка.");
            }
            else if (thing == "xbox")
            {
                Console.WriteLine("В гостинной. На тумбочке.");
            }
            else if (thing == "телефон")
            {
                Console.WriteLine("В твоей комнате. На столе.");
            }
            else if (thing == "записка с паролем от dota2")
            {
                Console.WriteLine("Прикреплена к настольной лампе.");
            }
            else
            {
                Console.WriteLine("Не знаю такой вещи.");
            }
            Console.ReadLine();
        }
    }
}
