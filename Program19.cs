using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program19
    {
        public static int findJudge(int N, int[][] trust)
        {
            int[] iiin = new int[N + 1];
            int[] outt = new int[N + 1];
            foreach (int[] a in trust)
            {
                outt[a[0]]++;
                iiin[a[1]]++;
            }
            for (int i = 1; i <= N; ++i)
            {
                if ((iiin[i] == N - 1) && (outt[i] == 0))
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            int n = 3;
            int[][] trust1 = { new[]{ 1, 3 }, new[]{ 2, 3 }
            //, new[]{ 3, 1 } 
            };
            Console.WriteLine(findJudge(n, trust1));

        }
    }
}
