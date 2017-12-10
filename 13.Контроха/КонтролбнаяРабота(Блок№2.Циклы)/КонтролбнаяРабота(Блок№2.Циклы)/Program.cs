using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace КонтролбнаяРабота_Блок_2.Циклы_
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempt = 0;
            Console.WriteLine("Привет, Василий! Загадай число (не больше 999):");
            int VasyaNumber = int.Parse(Console.ReadLine());
            if (VasyaNumber < 999)
            {
                while (true)
                {
                    Console.WriteLine("Валерка, отгадывай число:");
                    int ValeraNumber = int.Parse(Console.ReadLine());

                    if (ValeraNumber > VasyaNumber)
                    {
                        Console.WriteLine("Твоё число больше загаданного числа Василия.");
                        attempt++;
                    }
                    else if (ValeraNumber < VasyaNumber)
                    {
                        Console.WriteLine("Твоё число меньше загаданного числа Василия.");
                        attempt++;

                    }
                    else if (ValeraNumber == VasyaNumber)
                    {
                        attempt++;
                        Console.WriteLine("Молодец! Ты угадал! Количество твоих попыток: " + attempt);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введено число, большее/равное 999! Закрываюсь!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
            Console.ReadLine();
            
        }
    }
}
