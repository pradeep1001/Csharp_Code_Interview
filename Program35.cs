using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program35
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int iintLength1 = word1.Length;
            int iintLength2 = word2.Length;
            int maxLength = Math.Max(iintLength1, iintLength2);
            string istroutput = "";
            for (int i = 0; i < maxLength; i++)
            {
                if (iintLength1 > i)
                {
                    istroutput += word1;
                }
                if (iintLength2 > i)
                {
                    istroutput += word2;
                }
            }

            return istroutput;
        }

    }
}
