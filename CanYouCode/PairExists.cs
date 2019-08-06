
namespace CanYouCode
{
    /// <summary>
    ///  A method to check if a pair exists with a given sum
    /// </summary>
    public static class PairExists
    {
        public static bool ArraySumsTo(int[] numbers, int sumsTo)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == sumsTo)
                        return true;
                }
            }

            return false;
        }
    }
}
