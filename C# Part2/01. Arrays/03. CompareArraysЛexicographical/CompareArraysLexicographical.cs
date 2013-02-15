//3. Write a program that compares two char arrays 
//lexicographically (letter by letter).

using System;

class Program
{
    static void Main()
    {
        Console.Write("First array size - ");
        int sizeOne = int.Parse(Console.ReadLine());
        Console.Write("Second array size - ");
        int sizeTwo = int.Parse(Console.ReadLine());
        char[] firstArray = new char[sizeOne];
        char[] secondArray = new char[sizeTwo];

        Console.WriteLine("Data for the first array!");
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Data for the second array!");
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        int size = firstArray.Length < secondArray.Length ? firstArray.Length : secondArray.Length;
        for (int i = 0; i < size; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                continue;
            }
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("First array is earlier!");
                break;
            }
            else
            {
                Console.WriteLine("Second array is earlier");
                break;
            }
        }
    }
}