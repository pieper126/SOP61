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
            Write writer = new Write();
            Assert.AreEqual("this is long", writer.WriteVerse("longverse"));
        }
    }
}
