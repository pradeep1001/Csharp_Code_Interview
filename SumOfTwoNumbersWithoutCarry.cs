using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class SumOfTwoNumbersWithoutCarry
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            string[] nums = Console.ReadLine().Split();
            int num1 = int.Parse(nums[0]);
            int num2 = int.Parse(nums[1]);
            int sum = 0;
            int place = 1;
            while (num1 > 0 || num2 > 0)
            {
                int digit1 = num1 % 10;
                int digit2 = num2 % 10;
                sum += (digit1 + digit2) % 10 * place;
                num1 = num1 / 10;
                num2 = num2 / 10;
                place *= 10;
            }

            Console.WriteLine("Sum without carry: " + sum);
        }
    }

}
