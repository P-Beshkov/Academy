using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static int[] array;
    static int[] visited;
    static StringBuilder result = new StringBuilder();
    static bool leftBondReady = false;
    static int left = 0;
    static int right = 0;
    static void ResolveArray(int index)
    {
        if (index < 0 || index >= array.Length)
        {
            return;
        }
        if (visited[index] == 1 && leftBondReady==false)
        {
            left = index;        
            visited[index]=3;
            leftBondReady=true;
            ResolveArray(array[index]);            
        }
        if (visited[index] == 2)
        {
            right = index;
            return;
        }
        if (visited[index] == 0)
        {
            result.Append(index + " ");
        }
        visited[index]++;        
        ResolveArray(array[index]);
    }
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        array = new int[count];
        visited = new int[count];
        string allNumbers = Console.ReadLine();
        string[] rawNumbers = allNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < count; i++)
        {
            array[i] = int.Parse(rawNumbers[i]);
        }
        ResolveArray(0);
        int whitheSpace=0;
        string stringResult = result.ToString();
        foreach (char symbol in stringResult)
        {
            if (symbol == ' ')
            {
                whitheSpace++;
            }
            if (whitheSpace==left)
            {
                Console.Write('(');
            }
            if (whitheSpace==right)
            {
                Console.Write(')');
            }
            Console.Write(symbol);
        }
    }
}