using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    public class FindNextSmallestElement_Array
    {
        public static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            int n = int.Parse(firstLine);

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string output = new string(String.Join(" ", FindtheNextSmallestElementinArray(numbers)));
            Console.WriteLine(output);
        }
        public static int[] FindtheNextSmallestElementinArray(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int nextSmallestNumber = -1;
                int CurrentNum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < CurrentNum)
                    {
                        nextSmallestNumber = numbers[j];
                        break;
                    }
                }
                result[i] = nextSmallestNumber;
            }
            return result;
        }
    }
}
