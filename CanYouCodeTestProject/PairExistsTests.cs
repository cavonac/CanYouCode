using CanYouCode;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanYouCodeTestProject
{
    [TestClass]
    public class PairExistsTests
    {
        [TestMethod]
        public void SumsToInSortedArray()
        {
            // Arrange 
            int[] numbers = { 1, 2, 3, 4, 4, 5 };
            int sumsTo = 7;

            // Arrange
            bool exists = PairExists.ArraySumsTo(numbers, sumsTo);

            // Assert
            Assert.IsTrue(exists);
        }

        [TestMethod]
        public void SumsToInSortedArrayBaseCase()
        {
            int[] twoNumbers = { 3, 4 };
            Assert.IsTrue(PairExists.ArraySumsTo(twoNumbers, 7));
        }

        [TestMethod]
        public void SumsToFails()
        {
            int[] numbers = { 1, 2, 7 };
            Assert.IsFalse(PairExists.ArraySumsTo(numbers, 7));
        }
    }
}
