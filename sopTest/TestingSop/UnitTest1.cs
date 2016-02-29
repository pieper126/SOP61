using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sopTest;

namespace TestingSop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculate calculate = new Calculate();
            Assert.Equals(4, calculate.Plus(2, 2));
        }
    }
}
