//06. Write a method that returns the index of the first element in array that 
//is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class ReturnIndexMethod
{
    static private int FirstBiggerElement(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1])
            {
                if (array[i] > array[i + 1])
                {
                    return i;
                }
            }
        }
        return index;
    }

    static void Main()
    {
        int[] array = { 34, 1, -13, 31, 6, 12, 87, -4 };
        int index = FirstBiggerElement(array);        
        if (index == -1)
        {
            Console.WriteLine("There is no such element");
        }
        else
        {
            Console.WriteLine("The first element bigger than it's neighbors is [{0}] = {1}", index, array[index]);
        }
    }
}