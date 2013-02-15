//12. Write a program that creates an array containing all letters 
//from the alphabet (A-Z). Read a word from the console and print 
//the index of each of its letters in the array.

using System;

class Program
{
    static void Main()
    {
        char letter = 'A';
        char[] allLeters = new char[26];        
        for (int i = 0; i < allLeters.Length; i++)
        {
            allLeters[i] = letter;
            letter++;
        }
        Console.WriteLine("The array:");
        foreach (char item in allLeters)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();

        Console.Write("Your word:");
        string word = Console.ReadLine();
        word = word.ToUpper();

        Console.WriteLine("Index of each letter:");
        Console.WriteLine("Letter  : Index");
        foreach (char item in word)
        {
            string line = item + "\t: " + (item - 'A');            
            Console.WriteLine(line);
        }
    }
}

