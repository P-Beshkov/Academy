//15. * Modify your last program and try to make it work for any number
//type, not just integer (e.g. decimal, float, byte, etc.). Use 
//generic method (read in Internet about generic methods in C#).

using System;

class GenericCalculations
{
    static private void ShowParamsOfArray<T>(params T[] array) where T : IComparable
    {
        dynamic elementsSum = 0;
        dynamic product = 1;
        dynamic maximum ,
        minimum ;
        dynamic average = 0;
        minimum = array[0];
        maximum = array[0];
        foreach (T item in array)
        {
            Console.Write(item + " ");
            elementsSum += item;
            product *= item;
            if (item > maximum)
            {
                maximum = item;
            }
            if (item < minimum)
            {
                minimum = item;
            }
        }
        Console.WriteLine();
        average = elementsSum / array.Length;
        string format = "Minimum element  = {0}\n" +
                        "Maximum element  = {1}\n" +
                        "Average \t = {2}\n" +
                        "Sum \t\t = {3}\n" +
                        "Product \t = {4}\n";
        Console.WriteLine(format, minimum, maximum, average, elementsSum, product);
    }

    static void Main()
    {
        int[] arr = { };
        ShowParamsOfArray(3.6, 6.4, -32, 32.4, 66.4, 1000.8, 22, -33.4);
    }
}