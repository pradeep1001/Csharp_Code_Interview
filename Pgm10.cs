using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    class Pgm10
    {
        public static int longestSubarray(List<int> arr)
        {
            int[] arr1 = arr.ToArray();
            int[] duplicates = arr1
         .GroupBy(i => i)
         .Where(g => g.Count() == 2)
         .Select(g => g.Key)
         .ToArray();
            Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
            int sum = duplicates.Count();

            Console.WriteLine("Sum: " + sum);
            return sum * 2;
        }
        public static int longestSubarray(List<int> arr)
        {
            int n = arr.Count;
            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                List<int> w = new List<int>();
                int cnt = 0;

                for (int j = i; j < n; j++)
                {
                    if (w.Contains(arr[j]))
                    {
                        cnt++;
                        continue;
                    }

                    if (w.Count == 0)
                    {
                        w.Add(arr[j]);
                    }
                    else if (w.Count == 1)
                    {
                        if (Math.Abs(w[0] - arr[j]) > 1)
                        {
                            break;
                        }
                        else
                        {
                            w.Add(arr[j]);
                        }
                    }
                    else
                    {
                        break;
                    }
                    cnt++;
                }
                ans = Math.Max(ans, cnt);
            }
            return ans;
        }


        public static void Main(string[] args)
        {
            List<int> arr5 = new List<int> { 3,2,3,5 };

            int result = longestSubarray(arr5);
        }
    }
}

