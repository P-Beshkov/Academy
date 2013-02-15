//09. Write a program that finds the most frequent number in an array. 
//Example: 	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;
class Program
{
    static void Main()
    {
        Console.Write("Array size = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int count = 1,
            maxCount = 0,
            indexOfFrequentElement = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
            }
            else
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    indexOfFrequentElement = i - 1;
                    count = 1;
                }
                count = 1;
            }
        }
        Console.WriteLine("{0} - {1} times",array[indexOfFrequentElement], maxCount);

    }
}

