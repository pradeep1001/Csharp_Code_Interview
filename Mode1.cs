using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    class Mode1
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 12, 5, 7, 5, 21, 5 };
            Array.Sort(arr);
            int tot = 0;
            foreach (int i in arr)
            {
                tot += i;
            }
            Console.WriteLine(tot);
            int n = arr.Length;
            int mean = tot / n;
            Console.WriteLine("Value of mean is : " + mean);
            int median = 0;
            if (n % 2 == 0)
            {
                median = (arr[n / 2 - 1] + arr[n / 2]) / 2;
            }
            else
            {
                median = (arr[n / 2]) / 2;
            }
            Console.WriteLine("Value of median is : " + median);
            printMode(arr, n);
        }
        static void printMode(int[] a, int n)
        {



            int max = a.Max();


            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;


            for (int i = 0; i < n; i++)
                count[a[i]]++;


            int mode = 0;
            int k = count[0];
            for (int i = 1; i < t; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }

            Console.WriteLine("mode = " + mode);
        }

    }
}
