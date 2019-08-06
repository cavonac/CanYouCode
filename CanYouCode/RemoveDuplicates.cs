using System;
using System.Collections.Generic;
using System.Linq;

namespace CanYouCode
{
    /// <summary>
    /// Removes duplicate elements in sorted and unsorted arrays
    /// </summary>
    public static class RemoveDuplicates<T> 
    {
        /// <summary>
        /// Linear search through an unsorted array. O(n)
        /// </summary>
        /// <param name="unsorted"></param>
        /// <returns></returns>
        public static T[] Unsorted(T[] unsorted)
        {
            if (unsorted == null)
                throw new ArgumentNullException();

            if (unsorted.Count() < 1)
                throw new ArgumentException("Array should contain values");

            var hs = new HashSet<T>();
            var retList = new List<T>(); // To maintain order of original array

            foreach (T val in unsorted)
            {
                if (!hs.Contains(val))
                {
                    hs.Add(val);
                    retList.Add(val);
                }
            }

            return retList.ToArray<T>();
        }

        /// <summary>
        /// Uses a Queue to maintain sort
        /// </summary>
        /// <param name="sorted">A sorted array that may contains duplicates</param>
        /// <returns>A sorted array without duplicates</returns>
        public static T[] Sorted(T[] sorted)
        {
            if (sorted == null)
                throw new ArgumentNullException();

            if (sorted.Count() < 1)
                throw new ArgumentException("Array should contain values");

            var q = new Queue<T>();

            T last = sorted[0];
            q.Enqueue(sorted[0]);

            foreach (T val in sorted)
            {                
                if (!last.Equals(val))
                {
                    q.Enqueue(val);
                    last = val;
                }
            }

            return q.ToArray();
        }

    }
}
