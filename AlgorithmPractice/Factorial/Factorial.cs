using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public static class Factorial
    {
        public static long Iterative(int n)
        {
            CheckAssertions(n);

            long result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        public static long Recursive(long n)
        {
            CheckAssertions(n);

            if (n == 0)
                return 1;

            return n * Recursive(n - 1);
        }

        private static void CheckAssertions(long n)
        {
            if (n < 0)
                throw new Exception($"Value ({n}) must be positive.");
        }
    }
}
