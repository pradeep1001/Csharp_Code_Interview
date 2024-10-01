using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program53
    {
        public static bool IsVowelOrNot(char c)
        {
            char[] chars = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
            foreach (char b in chars)
            {
                if (b == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {

            char abc = Convert.ToChar(Console.ReadLine());
            if (IsVowelOrNot(abc))
            {
                Console.WriteLine("Entered character is a vowel");
            }
            else
            {
                Console.WriteLine("Entered character is not a vowel");
            }
        }
    }
}
