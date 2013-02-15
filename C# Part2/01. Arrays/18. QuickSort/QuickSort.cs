//14. Write a program that sorts an array of strings 
//using the quick sort algorithm (find it in Wikipedia).

using System;

class Program
{
    static public int[] arr = { 6, 3, 155, 210, 143, 211 };
    static public void Swap(ref int a, ref int b)
    {
        int c;
        c = a;
        a = b;
        b = c;
    }

    static private void QuickSorting(int start, int end)
    {
        int left = start,
            right = end,
            key = arr[start];
        do
        {
            while (key > arr[left]) left++;
            while (key < arr[right]) right--;
            if (left == right)
            {
                left++;
                right--;
            }
            else if (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        while (left <= right);

        if (right > start)
        {
            QuickSorting(start, right);
        }
        if (left < end)
        {
            QuickSorting(left, end);
        }

    }
    static void Main()
    {
        QuickSorting(0, arr.Length - 1);
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
