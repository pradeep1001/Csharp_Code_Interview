using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    public class Program52
    {
        public static void Main(string[] args)
        {
            int[] input = { 1, 6, 4, 56, 56, 56, 6, 4, 2 };
            Dictionary<int, int> input2 = new Dictionary<int, int>();
            foreach (int i in input)
            {
                if (input2.ContainsKey(i))
                {
                    input2[i]++;
                }
                else
                {
                    input2[i] = 1;
                }
            }
            List<int> input3 = new List<int>();

            foreach (KeyValuePair<int, int> kvp in input2)
            {
                if (kvp.Value == 1)
                {
                    input3.Add(kvp.Key);
                }
            }
            int[] output = input3.OrderByDescending(x => x).ToArray();
            if (input3.Count == 0)
            {
                foreach (int i in input)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                foreach (int i in output)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
