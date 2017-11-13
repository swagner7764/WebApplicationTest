using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Barcode2DTest
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            double value = 12.99;
            double expected = 11.99;

            Assert.AreEqual(expected, value, 0.001, "Account not debited correctly");
        }
    }
}
