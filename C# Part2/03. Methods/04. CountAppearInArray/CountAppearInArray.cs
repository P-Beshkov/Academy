//04. Write a method that counts how many times given number appears in given 
//array. Write a test program to check if the method is working correctly.

using System;

class CountAppearInArray
{
    static private int CountInArray(int number, int[] array)
    {
        int count=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
    }
}