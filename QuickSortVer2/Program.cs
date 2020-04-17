using System;

namespace QuickSortVer2
{
    class Program
    {
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
                if (partition > 1)
                {
                    QuickSort(arr, begin, partition - 1);
                }
                if (partition + 1 < end)
                {
                    QuickSort(arr, partition + 1, end);
                }
            }
        }

        static int Partition(int[] arr, int begin, int end)
        {
            int pivot = arr[begin];
            while(true)
            {
                while (arr[begin] < pivot)
                {
                    begin++;
                }
                while (arr[end] > pivot)
                {
                    end--;
                }
                if (begin < end)
                {
                    if (arr[begin] == arr[end])
                    {
                        return end;
                    }
                    int temp = arr[begin];
                    arr[begin] = arr[end];
                    arr[end] = temp;
                }
                else
                {
                    return end;
                }
            }
        }
    }
}
