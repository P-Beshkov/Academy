//05. Write a method that checks if the element at given position in given 
//array of integers is bigger than its two neighbors (when such exist).

using System;

class CheckElement
{
    static private bool IsElementBigger(int[] arr, int index)
    {
        if (index != 0 && index < (arr.Length - 1))
        {
             if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
             {
                 return true;
             }
        }
        return false;
        

    }
    static void Main()
    {
        int[] array = { 3, 34, -13, 31, 6, 12, 87, -4 };
        foreach (int item in array)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();

        int index = 3;
        Console.WriteLine("Element with index {0} is bigger than its two neighbors - {1} ",index, IsElementBigger(array, index));
        index = 0;
        Console.WriteLine("Element with index {0} is bigger than its two neighbors - {1} ", index, IsElementBigger(array, index));
        index = array.Length - 1;
        Console.WriteLine("Element with index {0} is bigger than its two neighbors - {1} ", index, IsElementBigger(array, index));
    }
}