using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanYouCode;

namespace CanYouCodeTestProject
{
    [TestClass]
    public class RunLengthEncodingTests
    {
        [TestMethod]
        public void TestRunLengthEncoding()
        {
            String inputString = "wwwwwwwwwwwwwwwwwwXxiiIIll";
            String expected = "w18X1x1i2I2l2";

            Assert.AreEqual(inputString.RLEncode(), expected);
        }

        [TestMethod]
        public void TestRunLengthDecoding()
        {
            String coded = "w18X1x1i2I2l2";
            String expected = "wwwwwwwwwwwwwwwwwwXxiiIIll";

            Assert.AreEqual(expected, coded.RLDecode());
        }
    }   
}