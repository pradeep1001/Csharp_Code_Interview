using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program18
    {
        public static string maxSum(string w, char[] x, int[] b,
                              int n)
        {
            string ans = "", res = "";

            // If Length of the given string is 1
            // we can return the string.
            // It will be maximum in itself
            if (w.Length == 1)
                return w;
            long maxi = Int32.MinValue;
            long sum = 0;
            long longE = 0;
            Dictionary<int, int> mp
              = new Dictionary<int, int>();

            // Taking unordered_map to store
            // new ascii value of character in x[].
            for (int i = 0; i < 26; i++)
            {
                mp[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                mp[x[i] - 'a'] = b[i];
            }

            // Traversing through the string .
            for (int i = 0; i < w.Length; i++)
            {
                // Store the string in ans.
                ans += w[i];
                string temp;

                // If we find any redefined value of char
                // of string w, we will add that value
                // to the sum else add it's predefined value
                if (mp[w[i] - 'a'] == 0)
                {
                    sum += w[i];
                }
                else
                {
                    sum += mp[w[i] - 'a'];
                }

                // If anytime we find sum is getting negative
                // clear the values stored in "ans"
                // and make sum=0 again
                if (sum < 0)
                {

                    sum = 0;
                    ans = "";
                }

                // If sum is greater than maximum
                // maxi will be updated as sum and
                // new result would be string stored in ans
                if (sum > maxi)
                {
                    maxi = sum;
                    res = ans;
                }
            }
            return res;
        }

        public static void Main()
        {

            // Code
            string W = "abcde";
            int N = 1;
            char[] X = { 'c' };
            int[] B = { -1000 };

            // Function call
            Console.WriteLine(maxSum(W, X, B, N));
        }
    }
}
