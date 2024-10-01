using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program12
    {
        public static void Main(String[] args)
        {
            int sum = 0;
            for (int i = 0, j = 10; i < 5 && j > 5; ++i, --j)
            {
                sum += i + j;
            }
            Console.WriteLine(sum);
        }
    }
}
