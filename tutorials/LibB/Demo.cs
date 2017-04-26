using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibA;

namespace LibB
{
    public class Demo
    {
        public Demo() { }
        public static void TestLibA()
        {
            var a = new A();
            var map = a.Map;
        }
    }
}
