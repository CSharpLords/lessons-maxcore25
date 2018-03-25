using System;

namespace UpgradedSpaces {
	class Program {
		static void Main(string[] args) {
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

			int spacesAmount = CountSpaces(sentence);
			string spacesForm = GetSpacesForm(spacesAmount);
			Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " " + spacesForm);
			Console.ReadLine();
		}
	}
}
