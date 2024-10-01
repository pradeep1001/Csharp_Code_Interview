using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Parent
    {
        // below method is called 1st
        public Parent()
        {
            Console.Write("Parent ");
        }
        public Parent(int a)
        {
            Console.Write("Parent1 ");
        }
    }
    public class Child : Parent
    {
        public Child() : this(1)
        {
            Console.Write("Child ");
        }
        // below method is called 2nd
        public Child(int a)
        {
            Console.Write("Child1 ");
        }
    }
    class Program8
    {
        public static void Main(String[] args)
        {
            Child child = new Child(1);
        }
    }
}
