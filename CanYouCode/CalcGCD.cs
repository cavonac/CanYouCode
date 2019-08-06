using System;
using System.Collections.Generic;
using System.Linq;

namespace CanYouCode
{
    /// <summary>
    /// Calculates the greatest common divisor of two numbers
    /// </summary>
    public static class CalcGCD
    {
        public static int GreatestCommonDivisor(this int myInt, int compareTo)
        {
            int gcd = 1;

            List<int> myDivisors = GetDivisors(myInt);
            List<int> cDivisors = GetDivisors(compareTo);

            var intersected = myDivisors.AsQueryable().Intersect(cDivisors);

            foreach (var divisor in intersected)
            {
                if (divisor > gcd)
                    gcd = divisor;
            }

            return gcd;
        }

        private static List<int> GetDivisors(int input)
        {
            List<int> divisors = new List<int>();
            int max = (int)Math.Sqrt(input); // suitable stopping point 

            for (int divisor = 1; divisor <= max; ++divisor)
            {
                if (input % divisor == 0) // found
                {
                    divisors.Add(divisor);
                    if (divisor != input / divisor) 
                    {
                        divisors.Add(input / divisor); 
                    }
                }
            }

            return divisors;
        }
    }
}
