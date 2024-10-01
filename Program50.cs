using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Pradeep_1
{
    public class Program50
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            int[] abc = FirstNegativeNumbers(numbers, k);
        }
        public static int[] FirstNegativeNumbers(int[] numbers1, int k1)
        {

            int k = k1;
            int n = numbers1.Length;
            int firstNegativeNumbers = 0;
            int[] result = new int[n - k + 1];
            bool allPositiveNumbers = true;
            foreach (int num in numbers1)
            {
                if (num < 0)
                {
                    allPositiveNumbers = false;
                    break;
                }
            }
            for (int i = 0; i < n - k + 1; i++)
            {
                result[i] = 0;
            }
            if (allPositiveNumbers)
            {
                return result;
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    if (numbers1[i] < 0)
                    {
                        result[0] = numbers1[i];
                        firstNegativeNumbers = i;
                        break;
                    }
                }
                for (int i = k; i < n; i++)
                {
                    firstNegativeNumbers = i - k + 1;
                    if (numbers1[i - k] == result[i - k])
                    {
                        while (firstNegativeNumbers < i && numbers1[firstNegativeNumbers] >= 0)
                        {
                            firstNegativeNumbers++;
                        }
                    }
                    if (firstNegativeNumbers < i)
                    {
                        result[i - k + 1] = numbers1[firstNegativeNumbers];
                    }
                }
                if (firstNegativeNumbers != -1)
                {
                    result[n - k] = numbers1[firstNegativeNumbers];
                }
                return result;
            }

        }
    }
    //public static int[] FirstNegativeNumbers(int[] numbers1, int k1)
    //{

    //    int k = k1;
    //    int n = numbers1.Length;
    //    int firstNegativeNumbers = 0;
    //    int[] result = new int[n - k + 1];
    //   for(int i=0; i < n-k+1;i++)
    //    {
    //        result[i] = 0;
    //    }
    //   for(int i=0; i <k;i++)
    //    {
    //        if (numbers1[i]<0)
    //        {
    //            result[0]= numbers1[i];
    //            firstNegativeNumbers = i;
    //            break;
    //        }
    //    }
    //   for(int i=k;i<n;i++)
    //    {
    //        if (numbers1[i-k]== result[i-k])
    //        {
    //            while(firstNegativeNumbers<i && numbers1[firstNegativeNumbers]>=0)
    //            {
    //                firstNegativeNumbers++;
    //            }    
    //        }
    //        if(firstNegativeNumbers<i)
    //        {
    //            result[i - k + 1] = numbers1[firstNegativeNumbers];
    //        }
    //    }
    //   if(firstNegativeNumbers!=-1)
    //    {
    //        result[n - k] = numbers1[firstNegativeNumbers];
    //    }
    //   return result;
    //}
}

