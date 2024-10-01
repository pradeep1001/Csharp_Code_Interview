using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pradeep_1
{
    public class Program56
    {
        private static string result;
        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello world!";

            string a = "Something";
            return a;
        }
        public static async Task Main(String[] args)
        {
            await SaySomething();
            Console.WriteLine(result);

        }


    }
}
