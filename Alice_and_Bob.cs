using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Alice_and_Bob
    {
        static void Main(String[] args)
        {
            string[] str = new string[6] { "A", "A", "A", "B", "B", "A" };
            string astr = "";
            astr = Check(str) == true ? "combination is present" : "combination is not present";
            Console.WriteLine(astr);
        }

        public static bool Check(string[] arr)
        {
            int Alice = 0;
            int Bob = 0;
            // i<arr.lenth , since it should not throw array out of bound index exception
            for (int i = 1; i < arr.Length - 1; i++)
            {

                if (arr[i - 1] == arr[i] && arr[i] == arr[i + 1])
                {
                    if (arr[i] == "A")
                    {
                        Alice++;
                    }
                    else
                    {
                        Bob++;
                    }
                }

            }
            return Alice - Bob >= 1;


        }
    }
}

