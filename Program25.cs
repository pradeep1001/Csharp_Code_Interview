using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Parent
    {
        int a = 100;
        public virtual int Display() // Marked as virtual to allow overriding
        {
            return a;
        }
    }

    public class Child : Parent
    {
        int b = 200;
        public override int Display() // Correctly overrides the Parent's Display method
        {
            // Console.WriteLine can be used here if needed
            return b;
        }
    }
    class Program25
    {
        public static void Main(string[] args)
        {
            Parent obj = new Child();
            Console.WriteLine(obj.Display());
            obj = new Parent();
            // This will now correctly call the Child's Display method
            Console.WriteLine(obj.Display());
        }
    }
}
