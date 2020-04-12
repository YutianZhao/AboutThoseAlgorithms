using System;

namespace QuickSort
{
    class Program
    {
        // Quick Sort: just like Merge sort, but we pick pivots and partitions
        // Here we take the last element as our pivot. We can pick others
        // Time complexity: O(nlog(n)) ~ O(n^2)
        // Spae complexity: O(log(n))
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }

        static void QuickSort(int[] arr, int begin, int end)
        {
            if (begin < end)
            {
                int partition = Partition(arr, begin, end);
                QuickSort(arr, begin, partition - 1);
                QuickSort(arr, partition + 1, end);
            }
        }

        static int Partition(int[] arr, int begin, int end)
        {
            int pivot = arr[end];
            int i = begin - 1;
            for (int j = begin; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp1;

            return i + 1;
        }
    }
}
