//18.* Write a program that reads an array of integers and removes from it 
//a minimal number of elements in such way that the remaining array is 
//sorted in increasing order. Print the remaining sorted array. 
//Example: 	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

using System;
using System.Collections.Generic;

class Program
{    
    static long[] values = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
    static int[] position = new int[values.Length];
    static List<int> maxLenghtPositions = new List<int>();
    static int maxLenght = 0;

    static void GenerateCombinaton(int genForPosition, int after, int numbersToCombine)
    {
        if (genForPosition > numbersToCombine)
        {            
            long prevValue = values[position[0]];
            int currentLenght=0;
            for (genForPosition = 1; genForPosition < numbersToCombine; genForPosition++)
            {
                if (!(prevValue <= values[position[genForPosition]]))
                {
                    currentLenght = genForPosition;
                    break;
                }
                prevValue = values[position[genForPosition]];
                currentLenght++;
            }
            if (currentLenght > maxLenght)
            {
                maxLenghtPositions.Clear();
                for (int i = 0; i <= currentLenght; i++)
                {
                    maxLenghtPositions.Add(position[i]);
                }
            }
            return;
        }
        for (int p = (after + 1); p <= values.Length - 1; p++)
        {
            position[genForPosition - 1] = p;
            GenerateCombinaton(genForPosition + 1, p, numbersToCombine);
        }
    }
    static void Main()
    {
        //Console.Write("Array size = ");
        //int arraySize = int.Parse(Console.ReadLine());
        //int[] array = new int[arraySize];

        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write("[{0}] = ", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        for (int numbersToCombine = 1; numbersToCombine <= values.Length; numbersToCombine++)
        {
            GenerateCombinaton(1, 0, numbersToCombine);
        }
        for (int i = 0; i < maxLenghtPositions.Count; i++)
        {
            Console.Write("{0} ", values[maxLenghtPositions[i]]);
        }
        Console.ReadKey();
    }
}

