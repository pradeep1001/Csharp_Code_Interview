using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pradeep_1
{
    public class Program46
    {
        public static string[] FindRelativeRanks(int[] score)
        {
            int n = score.Length;
            string[] answer = new string[n];
            int[] sortedScores = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortedScores[i] = score[i];
            }
            string istrinput = "guvi";
            char[] input = istrinput.ToCharArray();
            foreach (char c in input)
            {
                Console.WriteLine(c);
            }
            Array.Sort(sortedScores);
            Array.Reverse(sortedScores);
            //int[] sortedScores = score.Select((val, idx) => val)
            //.OrderByDescending(val => val)
            //.ToArray();

            Dictionary<int, int> indices = sortedScores.Select((val, idx) => new { Value = val, Rank = idx + 1 })
                                                        .ToDictionary(x => x.Value, x => x.Rank);

            for (int i = 0; i < n; i++)
            {
                int rank = indices[score[i]];
                switch (rank)
                {
                    case 1:
                        answer[i] = "Gold Medal";
                        break;
                    case 2:
                        answer[i] = "Silver Medal";
                        break;
                    case 3:
                        answer[i] = "Bronze Medal";
                        break;
                    default:
                        answer[i] = rank.ToString();
                        break;
                }
            }

            return answer;
        }
        public static void Main(string[] args)
        {
            int[] abc = { 10, 2, 6, 5, 9, 12 };
            //string[] istr = FindRelativeRanks(abc);


            //Dictionary<int,int> abb = abc.Select((x,y)=> Value = x, Idx = y)
            //                             .Select((x,y)=> Value=x.Value, rank = Idx+1)
            //                             .ToDictionary(x => x.Value,x => x.Rank);
            Array.Sort(abc);
            foreach (int i in abc)
            {
                Console.WriteLine(i);
            }

        }
    }
}
