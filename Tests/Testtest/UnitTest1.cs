using System;
using Xunit;
using Shouldly;

namespace Testtest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int mytest = 1;
            mytest.ShouldBe(1);
        }
    }
}
