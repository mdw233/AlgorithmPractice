using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public class SelectionSort
    {
        public static int[] Run(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                //figure out which index has the min value in the remaining array
                //swap currrent with it
                var indexOfMin = GetIndexOfSmallestValue(array, i);
                Swap(ref array, i, indexOfMin);
            }

            return array;
        }

        public static int GetIndexOfSmallestValue(int[] array, int startIndex)
        {
            var minVal = array[startIndex];
            var minIndex = startIndex;
            for (var i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static void Swap(ref int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
