using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pradeep_1
{
    public class Program55
    {

        public static void Main(string[] args)
        {
            string str = "Malayalam";
            Dictionary<char, int> output = CharCount(str);
            foreach (var c in output)
            {
                Console.WriteLine($" occurences of {c.Key} is {c.Value}");
            }

        }
        public static Dictionary<char, int> CharCount(string input)
        {
            char[] chars = (input.ToLower()).ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            return charCount;
        }
    }
}
