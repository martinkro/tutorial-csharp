using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        delegate string GetString();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,C#.");
            int x = 0;
            GetString firstMethod = new GetString(x.ToString);
            Console.WriteLine("x={0}", firstMethod.Invoke());
        }
    }
}
