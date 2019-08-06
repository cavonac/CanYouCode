using CanYouCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanYouCodeTestProject
{
    [TestClass]
    public class RemoveDuplicatesTests
    {
        [TestMethod]
        public void RemoveDuplicatesFromUnsortedArray()
        {
            // Arrange
            int[] unsorted = {9, 3, 3, 0, 1, -1, 4, 3 };
            int[] expected = { 9, 3, 0, 1, -1, 4 };

            // Act
            int[] actual = RemoveDuplicates<int>.Unsorted(unsorted);

            // Assert
            int e = 0; // expected index
            foreach (int a in actual)
            {
                Assert.AreEqual(expected[e], a);
                e++;
            }            
        }

        [TestMethod]
        public void RemoveDuplicatesFromSortedArray()
        {
            // Arrange
            int[] sorted = { -1, 2, 2, 2, 3, 4, 5, 6, 6, 6, 9 };
            int[] expected = { -1, 2, 3, 4, 5, 6, 9 };

            // Act 
            int[] actual = RemoveDuplicates<int>.Sorted(sorted);

            // Assert 
            int e = 0;
            foreach (int a in actual)
            {
                Assert.AreEqual(expected[e], a);
                e++;
            }
        }
    }
}
