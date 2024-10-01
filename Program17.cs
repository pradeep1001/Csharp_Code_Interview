using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Program17
    {
        public static void Main(String[] args)
        {
            string istrInput1 = "John";
            string istrInput2 = "Smith";
            char[] istrInput11 = new char[istrInput1.Length];
            char[] istrInput22 = new char[istrInput2.Length];
            istrInput11 = istrInput1.ToCharArray();
            istrInput22 = istrInput2.ToCharArray();

            int iintTransaction = int.MinValue;
            int iintServer = int.MaxValue;

            int iintLength = Math.Max(istrInput1.Length, istrInput2.Length);
            string istrOutput = "";

            for (int i = 0; i < iintLength; i++)
            {
                if (i < istrInput1.Length)
                {
                    istrOutput += istrInput11[i];

                }
                if (i < istrInput2.Length)
                {
                    istrOutput += istrInput22[i];
                }
            }
            Console.WriteLine(istrOutput);
        }
    }
}
