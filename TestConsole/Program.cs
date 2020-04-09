using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TestConsole.Classes;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }
        
        static void MergeSort(int[] arr, int begin, int end)
        {
            if (begin < end)
            {
                int mid = (begin + end) / 2;
                MergeSort(arr, begin, mid);
                MergeSort(arr, mid + 1, end);
                Merge(arr, begin, mid, end);
            }
        }

        static void Merge(int[] arr, int begin, int mid, int end)
        {
            int n1 = mid - begin + 1;
            int n2 = end - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            int i, j;

            for (i = 0; i < n1; i++)
            {
                leftArray[i] = arr[begin + i];
            }
            for (j = 0; j < n2; j++)
            {
                rightArray[j] = arr[mid + j + 1];
            }

            int k = begin;
            i = 0;
            j = 0;
            
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
