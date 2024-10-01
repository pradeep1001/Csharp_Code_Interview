using MathNet.Numerics.Distributions;
using NPOI.XSSF.Streaming.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Program54
    {
        static void Process1()
        {
            try
            {
                WriteMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in Process1: {ex.Message}");
            }
        }

        static void WriteMessage()
        {
            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;
            try
            {
                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");

            }
        }
        public static void Main(string[] args)
        {
            decimal gradePointAverage = 3.99872831m;
            Console.WriteLine((int)gradePointAverage);
            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

        }

    }
}
