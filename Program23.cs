using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Customer
    {
        public string istrFirstName;
        public string istrLastName;
        public override bool Equals(object obj)
        {

            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            Customer other = (Customer)obj;
            return this.istrFirstName == other.istrFirstName && this.istrLastName == other.istrLastName;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(istrFirstName, istrLastName);
        }
        //public override bool Equals(object obj)
        //{

        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    if (!(obj is Customer))
        //    {
        //        return false;
        //    }
        //    Customer other = (Customer)obj;
        //    return this.istrFirstName == other.istrFirstName && this.istrLastName == other.istrLastName;

        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(istrFirstName, istrLastName);
        //}

    }
    class Program23
    {

        public static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.istrFirstName = "Robert";
            c1.istrLastName = "Chase";

            Customer c2 = new Customer();
            c2.istrFirstName = "Robert";
            c2.istrLastName = "Chase";

            Console.WriteLine(c1.Equals(c2));
            // Console.WriteLine(c1 == c2);
        }
    }
}
