using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class SumOfThe_Digits_OfANumber
    {
        public static void Main(string[] args)
        {
            int num = 124;
            int sum = 0;
           
            while (num != 0)
            {
                int remainder = num % 10;

                sum += remainder;
                num = num / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
