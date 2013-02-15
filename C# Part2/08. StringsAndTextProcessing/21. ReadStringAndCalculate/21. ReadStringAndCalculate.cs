/* 21. Write a program that reads a string from the console and prints 
 * all different letters in the string along with information how 
 * many times each letter is found. */

using System;

class ReadStringAndCalculate
{
    static void Main()
    {
        string text = Console.ReadLine();
        int[] lettersCount = new int[52];
        foreach (char letter in text)
        {
            if (char.IsLetter(letter))
            {
                lettersCount[letter - 'A']++;
            }
        }
        for (int i = 0; i < 52; i++)
        {
            if (lettersCount[i] != 0)
            {
                Console.WriteLine("Letter {0} - {1} times", (char)(i + 'A'), lettersCount[i]);
            }
        }
    }
}