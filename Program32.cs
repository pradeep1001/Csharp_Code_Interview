using System;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{


    public class Program32
    {
        static void Main()
        {
            string url = "https://www.facebook.com";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD"; // Use HEAD request to retrieve only headers

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Console.WriteLine("Cache-Related Headers:");

                // Check if the response contains cache-related headers
                if (response.Headers["Cache-Control"] != null)
                {
                    Console.WriteLine($"Cache-Control: {response.Headers["Cache-Control"]}");
                }

                if (response.Headers["Expires"] != null)
                {
                    Console.WriteLine($"Expires: {response.Headers["Expires"]}");
                }

                if (response.Headers["Last-Modified"] != null)
                {
                    Console.WriteLine($"Last-Modified: {response.Headers["Last-Modified"]}");
                }

                if (response.Headers["ETag"] != null)
                {
                    Console.WriteLine($"ETag: {response.Headers["ETag"]}");
                }
            }
        }
    }
}
