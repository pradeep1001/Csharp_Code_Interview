﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    class Program20
    {
        public static void Main(String[] args)
        {
            char[] arr1 = { 'r', 'r', 'r', 'r', 'r', 'g', 'b', 'b', 'y', 'y' };

            Dictionary<char, int> MyDictionary = new Dictionary<char, int>();
            foreach (char c in arr1)
            {
                if (char.IsLetter(c))
                {
                    if (MyDictionary.ContainsKey(c))
                    {
                        MyDictionary[c]++;
                    }
                    else
                    {
                        MyDictionary[c] = 1;
                    }

                }
            }
            int MaximumValue = 0;

            MaximumValue = MyDictionary.Values.Max();
            // int[] arr = new int[MyDictionary.Count];
            var FirstOddValue = MyDictionary.Values.Where(value => value % 2 != 0).FirstOrDefault();
            var MinOddValue = MyDictionary.Values.Where(value => value % 2 != 0).Min();
            var MaxOddValue = MyDictionary.Values.Where(value => value % 2 != 0).Max();


            Console.WriteLine(MaximumValue);
            Console.WriteLine(FirstOddValue);
            Console.WriteLine(MinOddValue);
        }
    }
}
