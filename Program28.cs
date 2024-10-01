using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class MyException : Exception
    {
        public MyException(string message, Exception inner) : base(message, inner)
        {

        }
        public MyException()
        {

        }
        public MyException(string message) : base(message)
        {

        }
    }
    class Program28
    {
        public static Tuple<int, int, string> abc()
        {
            var tauthor = Tuple.Create(10, 23, "abc");
            return tauthor;
        }
        public static void Main(String[] args)
        {
            var a = Tuple.Create(10, 23, 23, 34, 56);

            var b = abc();

            var c = ("abc", "dc", "1234");

            var d = new[] { c.Item1, c.Item2, c.Item3 };
        }
    }
}
