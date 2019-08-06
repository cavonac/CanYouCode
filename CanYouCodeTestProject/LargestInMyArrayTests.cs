using CanYouCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanYouCodeTestProject
{
    [TestClass]
    public class LargestInMyArrayTests
    {
        [TestMethod]
        public void TestKthLargestInMyArray()
        {
            int [] arr = {3, 9, 19, 20, 1, 2};            

            var kthLargest = LargestInMyArray<int>.GetKthLargest(arr, 3);

            Assert.AreEqual(kthLargest, 9);
        }
    }
}
