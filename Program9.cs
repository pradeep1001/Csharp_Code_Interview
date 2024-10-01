using Pradeep_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class Parent
    {
        //Below method is called 1st
        public Parent()
        {
            Console.Write("Parent ");
        }
    }
    public class Child : Parent
    {
        //Below method is called 3rd
        public Child() : this(1)
        {
            Console.Write("child");
        }
        //Below method is called 2nd
        public Child(int a)
        {
            Console.Write("Child1 ");
        }
    }

    class Program9
    {
        public static void Main(String[] args)
        {
            Child child = new Child();
        }
    }
}
