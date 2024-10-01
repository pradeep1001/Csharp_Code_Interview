using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program51
    {
        public static void Main(string[] args)
        {
            int n = 2;
            int result = TotalSavings(n);
        }
        public static int TotalSavings(int n)
        {
            if (n <= 0)
            {
                return 1000;
            }
            if (n == 1)
            {
                return 2000;
            }
            int[] sum = new int[n + 1];
            sum[0] = 1000;
            sum[1] = 1000;
            for (int i = 2; i <= n; i++)
            {
                sum[i] = sum[i - 1] + sum[i - 2];
            }
            int total = 0;
            for (int i = 0; i <= n; i++)
            {
                total += sum[i];
            }
            return total;
        }
    }
}
