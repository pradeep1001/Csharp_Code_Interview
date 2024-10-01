using NPOI.XSSF.Streaming.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Min_element_inArray
    {
        public static void Main(string[] args)
        {

            int[] arr = { 3, 4, 9, 1, 6 };
            int min = arr[0];
            foreach (int i in arr)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine(min);
        }
    }
}
