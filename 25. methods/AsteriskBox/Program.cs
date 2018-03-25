using System;

namespace AsteriskBox 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			PrintAsteriskBox(20, 10);
			Console.ReadLine();
		}
        static void PrintAsterisks(int amountOfStars)
        {
            string star = "*";
            for (int n = 1; n < amountOfStars; n++)
            {
                star = star + "*";
            }
            Console.WriteLine(star);
        }
        static void PrintAsteriskBox(int width, int height)
        {
            for (int n = 0; n < height; n++)
            {
                PrintAsterisks(width);
            }
        }
	}
}
