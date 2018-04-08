using System;

namespace Spaces 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

			int spacesAmount = CountSpaces(sentence);
			Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " пробелов");
			Console.ReadLine();
		}

        static int CountSpaces(string sentence)
        {
            int space = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] == ' ')
                {
                    space++;
                }
            }
            return space;
        }
        
	}
}
