using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program37
    {

        public T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        public static void Main(string[] args)
        {
            Program37 p = new Program37();
            int c = p.Add<int>(2, 4);
            float d = p.Add<float>(5.2f, 1.0f);
            Console.WriteLine(d);
        }
    }
}
