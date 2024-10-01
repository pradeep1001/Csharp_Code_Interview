using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program49
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, -2, -3, -4, 5, 6, -7 };
            int k = 3;
            int[] abc = FindFirstNegativeIntegers(numbers, k);

        }
        static int[] FindFirstNegativeIntegers(int[] numbers, int k)
        {
            int n = numbers.Length;
            int[] result = new int[n - k + 1];
            int firstNegativeIndex = 0;

            // Initialize the result array with a default value indicating no negative integer
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            // Process the first window
            for (int i = 0; i < k; i++)
            {
                if (numbers[i] < 0)
                {
                    result[0] = numbers[i];
                    firstNegativeIndex = i;
                    break;
                }
            }

            // Slide the window and update the first negative integer
            for (int i = k; i < n; i++)
            {
                // Remove the first element of the previous window
                if (numbers[i - k] == result[i - k])
                {
                    firstNegativeIndex = i - k + 1;
                    while (firstNegativeIndex < i && numbers[firstNegativeIndex] >= 0)
                    {
                        firstNegativeIndex++;
                    }
                }

                // Update the first negative integer for the current window
                if (firstNegativeIndex < i)
                {
                    result[i - k + 1] = numbers[firstNegativeIndex];
                }
            }
            if (firstNegativeIndex != -1)
            {
                result[n - k] = numbers[firstNegativeIndex];
            }
            return result;
        }
    }
}
