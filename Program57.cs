using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pradeep_1
{
    public class Program57
    {
        private static string result = "";
        public static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "abc";
            return "Hello World";

        }
        public static void Main(string[] args)
        {
            SaySomething();
            Console.WriteLine(result);
        }
    }
}
