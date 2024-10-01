using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{

    public class Program44
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Rotate1(arr1, k);
        }
        public static void Rotate1(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, n - k);
        }
    }


}
