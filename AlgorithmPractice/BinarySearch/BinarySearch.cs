using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.BinarySearch
{
    public class BinarySearch
    {
        public static int Run(int[] sortedValues, int search)
        {
            int min = 0;
            int max = sortedValues.Length - 1;
            
            while (min <= max)
            {
                int guessIndex = (max + min) / 2;
                int guessValue = sortedValues[guessIndex];

                if (guessValue == search)
                    return guessIndex;

                if (guessValue > search)
                    max = guessIndex - 1;
                else
                    min = guessIndex + 1;
            }

            return -1;
        }
    }
}
