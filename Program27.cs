using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{

    class Program27
    {
        public static bool IsPrime(int num)
        {

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int CountPrimes(int n)
        {
            int iintCount = 0;
            if (n <= 2)
            {
                return 0;
            }
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    iintCount++;
                }
            }
            return iintCount;

        }
        public static void Main()
        {
            Program27 p = new Program27();
            // Let us search 3 in below array
            //int[] arr1 = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            //int n = arr1.Length;
            //int key = 3;
            Console.Write("Index of the element is : "
                          + p.CountPrimes(10));
        }
    }
}
