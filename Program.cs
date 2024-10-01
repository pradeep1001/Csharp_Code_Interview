using System;

namespace Pradeep_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //Console.WriteLine("Enter the number upto which you want to find Perfect numbers:");
            //n = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect numbers are displayed below:");
            for (int i = 1; i <= 10000; i++)
            {
                int temp = 0;
                temp = SumFactors(i);
                if (i == temp)
                {
                    Console.WriteLine(i + " is a perfect number");
                }

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
