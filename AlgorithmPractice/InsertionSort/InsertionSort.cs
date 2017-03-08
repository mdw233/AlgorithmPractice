using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public static class InsertionSort
    {
        public static int[] Run(int[] array)
        {
            //already sorted
            if (array.Length <= 1)
                return array;

            for (var i = 0; i < array.Length - 1; i++)
            {
                MoveNextElementIntoSortedSubarray(array, i);
            }

            return array;
        }

        private static void MoveNextElementIntoSortedSubarray(int[] fullArray, int rightmostSortedIndex)
        {
            var firstUnsortedElement = rightmostSortedIndex + 1;
            var value = fullArray[firstUnsortedElement];

            int i;
            for (i = rightmostSortedIndex; i >=0 && fullArray[i] > value; i--)
            {
                //we know that value is still <= the current index because we're still in the loop
                //otherwise we would have exited
                fullArray[i + 1] = fullArray[i]; //move the current value over one
            }
            fullArray[i + 1] = value;
        }
    }
}
