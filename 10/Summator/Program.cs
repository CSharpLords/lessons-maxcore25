using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summator {
    class Program {
        static void Main(string[] args) {
            while (true) {
                int sum = 0;
                Console.WriteLine("Введите число");

                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Сумма всех чисел: " + (sum + number));
                Console.WriteLine();
            }
        }
    }
}
