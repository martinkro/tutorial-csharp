using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Aysnc!");
            CallerWithAsync();
            Console.WriteLine("Hello,END");
            Console.ReadLine();
        }

        static string Greeting(string name)
        {
            Thread.Sleep(3000);
            return string.Format("Hello,{0}", name);
        }

        static Task<string> GreetingAsync(string name)
        {
            return Task.Run<string>(() => { return Greeting(name); });
        }

        private async static void CallerWithAsync()
        {
            string result = await GreetingAsync("Stephanie");
            Console.WriteLine(result);
        }
    }
}
