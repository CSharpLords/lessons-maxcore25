using System;
namespace AsteriskLine 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			PrintAsterisks(10);
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
	}
}
