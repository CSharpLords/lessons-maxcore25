using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._12._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {34, 675, 22, 100, 560, 50};
            
            for (int i = 0; i < nums.Length; i++)
            {
                double a = nums[i] / nums[0];
                
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
