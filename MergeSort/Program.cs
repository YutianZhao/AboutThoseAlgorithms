using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            MergeSort(arr, 0, arr.Length - 1);
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
            int M = mid - begin + 1;
            int N = end - mid;
            int[] leftArray = new int[M];
            int[] rightArray = new int[N];
            int i, j;
            for (i = 0; i < M; i++)
            {
                leftArray[i] = arr[begin + i];
            }
            for (j = 0; j < N; j++)
            {
                rightArray[j] = arr[mid + j + 1];
            }

            int k = begin;
            i = 0;
            j = 0;
            while (i < M && j < N)
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
            while (i < M)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < N)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}