//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Pradeep_1
//{
//    class Pradeep2
//    {
//        static void Main(string[] args)
//        {
//            // int n;
//            for (int n = 0; n < 10000; n++)
//            {


//                int temp1, temp2;
               
//                    temp1 = SumFactors(n);
//                    temp2 = SumFactors(temp1);
//                    if (n != temp1)
//                    {
//                        if (n == temp2)
//                        {
//                            Console.WriteLine(n + " and " + temp1 + " are amicable numbers");
//                            //Console.WriteLine(i + " is amicable number");
//                        }
//                    }
                
//            }
//            Console.ReadKey();
//        }
//        public static int SumFactors(int a)
//        {
//            int sum1 = 0;
//            for (int i = 1; i < a; i++)
//            {

//                if (a % i == 0)
//                {
//                    sum1 = sum1 + i;
//                }

//            }
//            return sum1;
//        }
//    }
//}
