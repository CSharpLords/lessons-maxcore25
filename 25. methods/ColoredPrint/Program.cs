using System;

namespace ColoredPrint {
	class Program {
		static void Main(string[] args) {
			// вызов метода PrintColoredText c разными аргументами
			PrintColoredText("This text should be red", ConsoleColor.Red);
			PrintColoredText("This text should be yellow", ConsoleColor.Yellow);

			Console.ReadLine();
		}

		static void PrintColoredText(string text, ConsoleColor color) {
			// пиши код здесь
		}
	}
}
