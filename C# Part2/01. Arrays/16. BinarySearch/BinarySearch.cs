//11. Write a program that finds the index of given element in a sorted array 
//of integers by using the binary search algorithm (find it in Wikipedia).

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 6, 3, 155, 210, 143, 211 };
        Array.Sort(arr);
        Console.Write("Value for search = ");
        int key = int.Parse(Console.ReadLine());
        int first = 0;
        int last = arr.Length - 1;
        int middle = last / 2;
        do
        {
            if (key == arr[middle])
            {
                Console.WriteLine("ELement found");
                break;
            }
            if (first == (last-1))
            {
                if (key == arr[first] || key ==arr[last])
                {
                    Console.WriteLine("ELement found");
                    break;
                }
                Console.WriteLine("Element not found, sorry!");
                break;
            }
            middle = (last + first) / 2;
            if (key < arr[middle])
            {
                last = middle;
                continue;
            }
            if (key > arr[middle])
            {
                first = middle;
                continue;
            }

        } while (true);

    }
}

