using System;

namespace UpgradedSpaces 
{
	class Program 
    {
		static void Main(string[] args)
        {
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

			int spacesAmount = CountSpaces(sentence);
			string spacesForm = GetSpacesForm(spacesAmount);
			Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " " + spacesForm);
			Console.ReadLine();
		}
        static int CountSpaces(string sentence)
        {
            int space = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    space++;
                }
            }
            return space;
        }
        static string GetSpacesForm(int spacesAmount)
        {
            if(spacesAmount == 1)
            {
                return "пробел";
            }
            if (spacesAmount > 1 && spacesAmount < 5)
            {
                return "пробелa";
            }
            if (spacesAmount > 4 && spacesAmount < 21)
            {
                return "пробелов";
            }
            return "";
        }
	}
}
