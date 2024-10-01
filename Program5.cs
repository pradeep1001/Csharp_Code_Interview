using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{

    class Program5
    {
        public static int GetMarks(string name)
        {
            if (name.Equals("tom"))
            {
                try
                {

                    // int i = 0;
                    int b = 0;
                    int i = 9 / b;
                    return 100;
                }
                catch (ArithmeticException e)
                {
                    return 60;
                }
                finally
                {
                    //return 40;
                    Console.WriteLine("hello");
                }
            }
            else if (name.Equals("peter"))
            {
                return 95;
            }
            else
            {
                return -1;
            }
        }
        public static int Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                return result;
            }
            catch (DivideByZeroException)
            {
                // Handle the exception
                return 0; // Return a default value in case of an exception
            }
            finally
            {
                // You can return a value from here, and it will override previous return statements
                Console.WriteLine("Hello");
            }
        }
        public static int calculate()
        {
            try
            {
                int a = 2;
                int b = 0;
                return a / b;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("abcd123");
                return 1;
            }
            finally
            {
                //return 0;
                Console.WriteLine("abcd");
            }
        }

        static void Main(string[] args)
        {
            int m = calculate();
            Console.WriteLine(m);
        }
    }
}
