using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestASP;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, calculator.Plus(2, 2));
            Assert.AreEqual(7, calculator.Plus(5, 2));
            Assert.AreEqual(1, calculator.Min(100, 99));
            Assert.AreEqual(55, calculator.Min(100, 45));
            Assert.AreEqual(20, calculator.Keer(5, 4));
            Assert.AreEqual(100, calculator.Keer(100, 1));
        }
    }
}
