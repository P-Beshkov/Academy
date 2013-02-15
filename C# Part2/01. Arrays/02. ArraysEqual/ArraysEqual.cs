//2. Write a program that reads two arrays from the console 
//and compares them element by element.

using System;

class Program
{
    static void Main()
    {
        Console.Write("First array size - ");
        int sizeOne = int.Parse(Console.ReadLine());
        Console.Write("Second array size - ");
        int sizeTwo = int.Parse(Console.ReadLine());
        int[] firstArray = new int[sizeOne];
        int[] secondArray = new int[sizeTwo];
        
        Console.WriteLine("Data for the first array!");
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Data for the second array!");
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        
        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Arrays are different by size!");
            return;
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("Arrays are different!\nElements with index {0} are not equal!", i);
                    return;
                }
            }
        }
        Console.WriteLine("Arrays are equal");
    }
}