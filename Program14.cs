using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program14
    {
        static void inmethod(in int x)
        {
            //x += 5;
            //x = 90;//
            // above implementations cannot be done

        }

        static void outmethod(out int y)
        {
            y = 10;
        }

        static void refmethod(ref int z)
        {
            z = z + 5;
        }
        public static void Main(string[] args)
        {
            int iintref = 10;

            int iintinPara = 2;

            Console.WriteLine("ref value before changing " + iintref);
            refmethod(ref iintref);
            Console.WriteLine("ref value before changing " + iintref);

            outmethod(out int bb);
            Console.WriteLine("out value after changing " + bb);

            Console.WriteLine("in value before changing " + iintinPara);
            inmethod(in iintinPara);
            Console.WriteLine("in value after changing " + iintinPara);


        }
    }
}
