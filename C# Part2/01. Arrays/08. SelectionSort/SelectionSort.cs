//07. Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Array size = ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
       
        int tempIndex = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i];
            tempIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    tempIndex = j;
                }
            }
            if (min == arr[i])
                continue;
            else
            {
                arr[i] += arr[tempIndex];
                arr[tempIndex] = arr[i] - arr[tempIndex];
                arr[i] -= arr[tempIndex];
            }
        }
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}