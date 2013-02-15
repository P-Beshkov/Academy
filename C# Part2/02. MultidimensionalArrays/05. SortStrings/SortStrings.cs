//05. You are given an array of strings. Write a method that sorts the 
//array by the length of its elements (the number of characters composing them).

using System;
class SortStrings
{
    static void Main()
    {
        string[] words = { "dds", "moreletters", "12345", "s", "dd" };
        foreach (string item in words)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));
        foreach (string item in words)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
}

