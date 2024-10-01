using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Pradeep1
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number upto which you want to find sum of factor");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum1 = 0;
                sum1 = SumFactors(i);
                Console.WriteLine("Sum of factors for the number " + i + "is: " + sum1);
            }
            Console.ReadKey();
        }
        public static int SumFactors(int a)
        {
            int sum1 = 0;
            for (int i = 1; i < a; i++)
            {

                if (a % i == 0)
                {
                    sum1 = sum1 + i;
                }

            }
            return sum1;
        }
    }

}
