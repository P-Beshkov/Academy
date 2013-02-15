//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class Program
{
    static private int[] SumLargeInt(int[] firstAddend, int[] secondAddend)
    {
        int biggerLenght = firstAddend.Length > secondAddend.Length ? firstAddend.Length : secondAddend.Length;
        int smallerLenght = firstAddend.Length > secondAddend.Length ? secondAddend.Length : firstAddend.Length;
        int[] result = new int[biggerLenght + 1];
        for (int i = 0; i < smallerLenght; i++)
        {
            result[i] = firstAddend[i] + secondAddend[i];
            if (result[i] > 9)
            {
                result[i + 1] = 1;
                result[i] = result[i] % 10;
            }
        }
        int[] biggerAddend = firstAddend.Length > secondAddend.Length ? firstAddend : secondAddend;
        for (int i = smallerLenght; i < biggerLenght; i++)
        {
            result[i] = biggerAddend[i];
            if (result[i] > 9)
            {
                result[i + 1] = 1;
                result[i] = result[i] % 10;
            }
        }
        return result;
    }

    static void Main()
    {
        int[] first = { 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9, 3, 2, 9, 9 };
        int[] second = { 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1, 5, 9, 6, 3, 8, 1 };
        int[] result = SumLargeInt(first, second);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}