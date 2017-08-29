using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNET452
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,NET 4.5.2");
            Type type = typeof(Program);
            Console.WriteLine("Type Name:" + type.Name);
            
        }
    }
}
