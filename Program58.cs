using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    public class Program58
    {
        public static void Main(string[] args)
        {
            int[] numbers = { };
            try
            {
                int a = numbers.OrderByDescending(x => x).Distinct().First();
                Console.WriteLine($"The highest number is: {a}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("The array is empty. There is no highest number.");
            }
        }
    }
}
