using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public delegate void Edelegate(string str);
    class A
    {
        public event Edelegate Mevent;

        public void TriggerEvent()
        {
            if (Mevent != null)
            {
                Mevent("Trigger is generated");
            }
        }

    }
    class Program24
    {
        public static void Main(string[] args)
        {
            A a = new A();
            Program24 b = new Program24();
            a.Mevent += new Edelegate(b.TriggerCatch);
            a.TriggerEvent();
        }

        public void TriggerCatch(string str)
        {
            Console.WriteLine(str);
        }
    }
}
