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

            //[1, 5, 9, 13] ... 14
            //currIndex / currVal / min / max
            //1 / 5 / 0 / 3
            //x / x / 2 / 3

            int min = 0;
            int max = sortedValues.Length - 1;
            while (min <= max)
            {
                int currentIndex = (min + max) / 2;
                int currentValue = sortedValues[currentIndex];

                if (currentValue == search)
                    return currentIndex;

                if (currentValue < search)
                    min = currentIndex + 1;
                else //currentValue must be > search
                    max = currentIndex - 1;
            }

            return -1;
        }
    }
}
