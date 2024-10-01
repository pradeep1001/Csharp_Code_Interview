using NPOI.XSSF.Streaming.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public abstract class Shape
    {
        public abstract double area();
        public virtual void DisplayInfo()
        {
            Console.WriteLine("this is a shape");
        }

    }
    public class Program40 : Shape
    {
        public double radius;
        public Program40(double radius)
        {
            this.radius = radius;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a circle");
        }

        public override double area()
        {
            return Math.PI * radius * radius;
        }


        public static void Main(String[] args)
        {
            Program40 pg = new Program40(40);
            Console.WriteLine(pg.area());
            pg.DisplayInfo();
        }
    }
}
