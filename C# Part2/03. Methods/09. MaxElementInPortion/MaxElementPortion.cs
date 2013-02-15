//09. Write a method that return the maximal element in a portion of array of 
//integers starting at given index. Using it write another method that sorts 
//an array in ascending / descending order.

using System;

class MaxElementPortion
{
    static private int MaxElementInRange(int[] inArray, int startIndex, int endIndex)
    {
        int maxValueIndex = startIndex;
        int maxValue = inArray[maxValueIndex];
        
        for (int i = startIndex+1; i <= endIndex; i++)
        {
            if (inArray[i] > maxValue)
            {
                maxValueIndex = i;
                maxValue = inArray[maxValueIndex];
            }
        }
        return maxValueIndex;
    }
    static private void SimpleSort(int[] array, bool descending=false)
    {
        if (descending == false)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxElementIndex = MaxElementInRange(array, 0, array.Length - 1 - i);
                int temp = array[maxElementIndex];
                array[maxElementIndex] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxElementIndex = MaxElementInRange(array, i, array.Length - 1);
                int temp = array[maxElementIndex];
                array[maxElementIndex] = array[i];
                array[i] = temp;
            }
        }
    }
    static void Main()
    {
        int[] arr = { 34, 1, -13, 31, 6, 12, 87, -4 };
        SimpleSort(arr,true);
        foreach (int item in arr)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
}
