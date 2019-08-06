using CanYouCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanYouCodeTestProject
{
    [TestClass]
    public class ArrayIntersectionTests
    {
        [TestMethod]
        public void TestArrayIntersection()
        {
            int[] A = { 2, 3, 5, 7, 11 }, B = { 3, 5, 15, 31 };

            int[] expected = { 3, 5 };

            int[] actual = ArrayIntersection<int>.Intersect(A, B);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
