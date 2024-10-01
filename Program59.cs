using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    class Program59
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 3, 7 };

            int highestnumber = numbers.OrderByDescending(x => x).Distinct().Skip(0).FirstOrDefault();
            Console.WriteLine(highestnumber);
            
            //2nd Method
            
            int highestNumber = int.MinValue;
            int SecondHighestNumber = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > highestNumber)
                {
                    SecondHighestNumber = highestNumber;
                    highestNumber = number;
                }
                else if (number < highestNumber && number > SecondHighestNumber)
                {
                    SecondHighestNumber = number;
                }
            }
        }
    }
}
