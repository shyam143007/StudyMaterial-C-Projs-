using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractObj = new ChildClass();
            abstractObj.VirtualMethod();
            //abstractObj.ChildMethod();

            

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, new Uri("http://www.apress.com/"));
            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
            System.Console.WriteLine(httpRequestMessage.ToString());

            System.Console.WriteLine();

            HttpResponseMessage response = new HttpResponseMessage();
            response.Headers.Add("x-name", "Custom header");
            System.Console.WriteLine(response.ToString())
                ;
            System.Console.WriteLine(MainAsync().GetAwaiter().GetResult());
            System.Console.Read();
        }

        private static async Task<int> MainAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://www.google.com");
            return response.Content.ReadAsStringAsync().Result.Length;
        }
    }
}
