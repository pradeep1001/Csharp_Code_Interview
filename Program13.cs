using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program13
    {
        static void Main()
        {

            int[] arr = { 0, 1, 0, 0 }; // assuming arr is an array of integers

            int n = arr.Length;            // initialize arr with values as needed

            int[] xyz = new int[4];
            int a = 0, b = n - 1;
            int temp;

            while (a < b)
            {
                if (arr[a] == 1 && arr[b] == 0)
                {
                    temp = arr[a];
                    arr[a] = arr[b];
                    arr[b] = temp;
                }
                else if (arr[a] == 1)
                {
                    b--;
                }
                else
                {
                    a++;
                }
            }

            Console.Write("The resultant array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }

}

