using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CheatConsoleTest
{
    public class CheatConsoleTest
    {
        [Fact]
        public void TestAdd()
        {
            int a = 1;
            int b = 2;
            Assert.Equal(3, a + b);
        }
    }
}
