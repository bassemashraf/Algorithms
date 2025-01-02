using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class AlgorithmsClass
    {
        public static int[] insertionSort(int[] unsortedList)
        {

            for (int i = 1; i < unsortedList.Count(); i++)
            {
                int key = unsortedList[i];
                int j = i - 1;
                while (j >= 0 && unsortedList[j] > key)
                {
                    unsortedList[j + 1] = unsortedList[j];
                    --j;
                }
                unsortedList[j + 1] = key;
            }
            return unsortedList;
        }
        public static void mergeSort(int[] unsortedList, int start, int end)
        {
            if (start >= end) return;
            int midpoint = (end + start) / 2;
            mergeSort(unsortedList, start, midpoint);
            mergeSort(unsortedList, midpoint + 1, end);
            merge(unsortedList, start, end, midpoint);


        }
        public static void merge(int[] unsortedList, int start, int end, int midpoint)
        {
            int i, j, k;
            int leftLength = midpoint - start + 1;
            int rightLength = end - midpoint;

            int[] leftArray = new int[leftLength];
            int[] rightArray = new int[rightLength];

            for (i = 0; i < leftLength; i++)
            {
                leftArray[i] = unsortedList[start + i];

            }
            for (j = 0; j < rightLength; j++)
            {
                rightArray[j] = unsortedList[midpoint + 1 + j];
            }

            i = 0;
            j = 0;
            k = start;
            while (i < leftLength && j < rightLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    unsortedList[k] = leftArray[i];
                    i++;
                }
                else
                {
                    unsortedList[k] = rightArray[j];
                    j++;
                }
                k++;

            }

            while (i < leftLength)
            {
                unsortedList[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightLength)
            {
                unsortedList[k] = rightArray[j];
                j++;
                k++;
            }


        }
    }
}
