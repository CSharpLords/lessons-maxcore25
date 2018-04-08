using System;

namespace Mathematics 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			Console.WriteLine(Sum(3, Multiply(7, 9)));
			Console.ReadLine();
		}
        static int Sum(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
        static int Multiply(int firstNumber, int secondNumber)
        {
            int multiply = firstNumber * secondNumber;
            return multiply;
        }

	}
}
