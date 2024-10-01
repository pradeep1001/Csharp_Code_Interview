using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class out1
    {
        static void Main(string[] args)
        {
            int a; // initailize of a is not required in the case of out parameter
            bool c;
            out1 obj1 = new out1();
            c = obj1.ChangingValue(out a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        public bool ChangingValue(out int b)
        {
            b = 54;
            return true;
        }
    }
}
