using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    interface MyEx1
    {
        public double getArea();
    }
    interface MyEx2
    {
        public string getColour();
    }
    class Rectangle : MyEx1, MyEx2
    {
        double idlength;
        double idbreadth;
        string istrColour;
        public Rectangle(double idlength, double idbreadth, string istrColour)
        {
            this.idlength = idlength;
            this.idbreadth = idbreadth;
            this.istrColour = istrColour;
        }
        public double getArea()
        {
            return idlength * idbreadth;
        }

        public string getColour()
        {
            return istrColour;
        }

    }
    class Program22
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2.5, 2, "Blue");
            Console.WriteLine(r.getArea());
            Console.WriteLine(r.getColour());
        }
    }
}
