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
        }

        static string Greeting(string name)
        {
            Thread.Sleep(3000);
            return string.Format("Hello,{0}", name);
        }
    }
}
