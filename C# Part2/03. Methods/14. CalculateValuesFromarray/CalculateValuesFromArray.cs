//14. Write methods to calculate minimum, maximum, average, sum and product 
//of given set of integer numbers. Use variable number of arguments.

using System;

class CalculateValuesFromArray
{
    static private void ShowParamsOfArray(params int[] array)
    {
        long elementsSum = 0;
        decimal product = 1;
        int maximum = int.MinValue,
        minimum = int.MaxValue;
        decimal average = 0;

        foreach (int item in array)
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
        ShowParamsOfArray(3, 6, -32, 32, 66, 1000, 22, -33);
    }
}