using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    //Example
    // C# program to demonstrate finall
    class Program29
    {
        // A method that throws an
        // exception and has finally.
        // This method will be called
        // inside try-catch.
        static void A()
        {
            try
            {
                Console.WriteLine("Inside A");
                throw new Exception("Throwing Exception");
            }

            finally
            {
                Console.WriteLine("A's finally");
            }
        }
        //Console.WriteLine("A's finally");
        // This method also calls
        // finally. This method
        // will be called outside
        // try-catch.
        static void B()
        {
            try
            {
                Console.WriteLine("Inside B");
                return;
            }
            finally
            {
                Console.WriteLine("B's finally");
            }
        }
        // Main Method
        public static void Main(String[] args)
        {
            try
            {
                A();
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }
            B();
            Console.WriteLine("Exception Caught");

        }
    }
}

