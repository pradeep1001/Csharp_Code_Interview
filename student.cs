using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    class Student
    {

        //static
        // static int id = 100;
        private int _name;
        public int max = 100;
        public int id
        {
            get { return _name; }
            private set { _name = max; }
        }
        string name;
        int age;
        int mark1;
        int mark2;

        static void Main(string[] args)
        {
            Student s = new Student();
            s.accept_data();
            s.display_data();
        }

        public void accept_data()
        {
            //Console.WriteLine("Enter id:");
            //this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            this.name = (Console.ReadLine());
            Console.WriteLine("Enter age:");
            this.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark1:");
            this.mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark2:");
            this.mark2 = int.Parse(Console.ReadLine());
        }
        public void display_data()
        {
            Console.WriteLine("\n" + this.id);
            Console.WriteLine(this.age);
        }

    }
}
