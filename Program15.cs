using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type the number of elements that we are going to store");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
        }
    }
}
