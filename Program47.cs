using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    public class Program47
    {
        public static T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        public static bool IsNull<T>(Stack<T> s)
        {
            return s.Count == 0;
        }
        public static void Main(String[] args)
        {
            string x = "hello";
            string y = "world";
            int a = 10;
            int c = 20;
            int[] arr = { 1, 3, 2, 0, 10, 5, 8, 7, 64 };
            int n = 2;
            int result = arr.Distinct().OrderBy(x => x).Skip(n - 1).FirstOrDefault();
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(a, c));

        }
    }
}
