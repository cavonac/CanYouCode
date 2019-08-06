using System.Collections.Generic;
using System.Linq;

namespace CanYouCode
{
    public static class ArrayIntersection<T>
    {
        public static T[] Intersect(T[] inputArr, T[] compareTo)
        {
            List<T> inList = new List<T>(inputArr);
            List<T> comparedToList = new List<T>(compareTo);

            return inList.AsQueryable<T>().Intersect<T>(comparedToList).ToArray<T>();
        }
    }
}
