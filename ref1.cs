using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class ref1
    {
        static void Main(String[] args)
        {
            int a = 15;
            bool c;
            ref1 obj1 = new ref1();
            c = obj1.ChangingValue(ref a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        public bool ChangingValue(ref int b)
        {
            //b = b + 1;
            return true;
        }
    }

}
