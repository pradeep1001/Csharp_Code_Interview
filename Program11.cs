using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program11
    {
        public static List<int> subarraySum(List<int> arr, int n, long s)
        {
            int sum = 0;
            int start = 0;
            int actualsum = Convert.ToInt32(s.ToString());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];

                a.Add(i + 1);

                while (sum > actualsum && start <= i)
                {
                    sum -= arr[start];


                    a.RemoveAt(start);
                    start++;
                }
                if (sum == actualsum)
                    break;
            }

            List<int> D = new List<int>();
            if (a.Count > 0)
            {
                D.Add(a[0]);
                D.Add(a[a.Count - 1]);
            }
            return D;

        }
        public static void Main(string[] args)
        {
            List<int> b = new List<int>();
            int n = 5;
            long s = 12;
            List<int> C = new List<int> { 1, 2, 3, 7, 5 };
            b = subarraySum(C, n, s);
        }
    }
}
