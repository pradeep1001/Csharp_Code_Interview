using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class pradeep3
    {
        static void Main(string[] args)
        {
            int a = 10;
            int c;
            pradeep3 p1 = new pradeep3();
            c = p1.changingvalue(in a);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        public int changingvalue(in int b)
        {
            // assignment cannot be done, since it is passed via "in" parameter
            int z = 90;
            z += b;
            return z;
        }
    }
}
