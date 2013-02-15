//13. * Write a program that sorts an array of integers using 
//the merge sort algorithm (find it in Wikipedia).

using System;

class Program
{
    static private int[] MergeSort(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }
        int middle = arr.Length / 2,
            leftIndex = 0,
            rightIndex = 0;

        int[] left = new int[middle],
              right = new int[arr.Length - middle],
              sorted = new int[arr.Length];

        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }
        for (int i = 0; i < arr.Length - middle; i++)
        {
            right[i] = arr[i + middle];
        }

        left = MergeSort(left);
        right = MergeSort(right);

        for (int i = 0; i < arr.Length; i++)
        {
            if (rightIndex == right.Length || (leftIndex < left.Length && (left[leftIndex] <= right[rightIndex])))
            {
                sorted[i] = left[leftIndex++];
            }
            else if (leftIndex == left.Length || ((rightIndex < right.Length) && (right[rightIndex] <= left[leftIndex])))
            {
                sorted[i] = right[rightIndex++];
            }
        }
        return sorted;
    }
    static void Main()
    {
        int[] arr = new int[100];
        int value = 100;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = value;
            value--;
        }

        arr = MergeSort(arr);

        foreach (int item in arr)
        {
           Console.WriteLine(item);           
        }        
    }
}
