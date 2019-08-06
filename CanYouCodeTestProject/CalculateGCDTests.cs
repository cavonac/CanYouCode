using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanYouCode;

namespace CanYouCodeTestProject
{
    [TestClass]
    public class CalculateGCDTests
    {
        [TestMethod]
        public void CalculateExample()
        {
            int myInt = 45;
            Assert.AreEqual(myInt.GreatestCommonDivisor(54), 9);
        }
    }
}
