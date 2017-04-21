using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CheatConsole;

namespace CheatConsoleTest
{

    public class SingletonTest
    {
        
        class A:Singleton<A>
        {

        }

        [Fact]
        public void TestSingleton()
        {
            A a = A.Instance;
            A b = A.Instance;
            Assert.Equal(a, b);
        }

        [Fact]
        public void TestSingleton2()
        {
            int a = 3;
            int b = 4;
            Assert.Equal(7, a + b);
        }
        
    }
}
