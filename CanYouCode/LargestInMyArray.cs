using System;

namespace CanYouCode
{
    public static class LargestInMyArray<T> where T : IComparable
    {
        public static T GetKthLargest(T[] arr, int kth)
        {
            QuickSort(arr);
            return arr[arr.Length - kth];
        }

        /// <summary>
        /// QuickSort is a divide and conquer algorithm that splits
        /// an array into two smaller arrays: low elements and high 
        /// elements. Using recursion, it sorts the partitions. 
        /// O(n log(n)) or at worst O(n^2)
        /// </summary>
        /// <param name="array">IComparable array to sort</param>
        public static void QuickSort(T[] array)
        {
            doQuickSort(array, 0, array.Length - 1);
        }

        private static void doQuickSort(T[] array, int first, int last)
        {
            /*
                if p < r
                    q = PARTITION(A, p, r)
                    QUICKSORT(A, p, q-1)
                    QUICKSORT(A, q+1, r)
            
                PARTITION(A, p, r)
                x=A[r]
                i=r
                for j = p to r - 1
                  if A <= x
                     i = i + 1
                     exchange A[i] with A[j]
                exchange A[i] with A[r]
                return i
            */

            if (first < last)
            {
                int pivotIndex = partition(array, first, last);
                doQuickSort(array, first, pivotIndex - 1);
                doQuickSort(array, pivotIndex + 1, last);
            }
        }

        private static int partition(T[] array, int left, int right)
        {
            T pivot = array[right];
            int i = left;
            T t;

            // Move along and compare 
            for (int j = left; j < right; j++)
            {
                if (array[j].CompareTo(pivot) <= 0)
                {
                    t = array[j];
                    array[j] = array[i];
                    array[i] = t;
                    i++;
                }
            }

            array[right] = array[i];
            array[i] = pivot;
            return i;
        }
    }
}
