using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nouns = {"Пяточка", "Василиска", "Лохушка", "Подмышка"};
            string[] adverbs = {" красиво ", " потрясаюсче ", " круто ", " хорошо "};
            string[] verbs = {" сдохла", " долбанулась", " обдолбалась", " обкурилась"};
            Random rand = new Random();
            for (int num = 0; num < 4; num++)
            {
                int indexNoun = rand.Next(0, 3);
                int indexAdverb = rand.Next(0, 3);
                int indexVerb = rand.Next(0, 3);
                Console.WriteLine(nouns[indexNoun] + adverbs[indexAdverb] + verbs[indexVerb]);
            }
            Console.ReadLine();
        }
    }
}
