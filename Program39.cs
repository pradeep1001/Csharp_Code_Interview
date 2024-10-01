using NPOI.XSSF.Streaming.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program39
    {
        public static void Main(String[] args)
        {
            string input1 = "abcdefg";
            int iintIterator = input1.IndexOf('d');
            int left = 0;
            int right = iintIterator;
            char[] chars = input1.ToCharArray();
            while (left < right && right >= 0)
            {
                char temp = chars[left];
                chars[left] = input1[right];
                chars[right] = temp;
                left++;
                right--;
            }
            string output = new string(chars);
        }
    }
}
