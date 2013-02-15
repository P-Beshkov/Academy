/* 24. Write a program that reads a list of words, separated by spaces 
 * and prints the list in an alphabetical order.*/

using System;
using System.Collections.Generic;

class SortWords
{
    static void Main()
    {
        string unsortedWords = "Write a program that reads list of words, separated by spaces and prints the in an alphabetical order";
        string[] words = unsortedWords.Split(new char[] {' ',',' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> wordList = new List<string>(words);
        wordList.Sort();
        foreach (string word in wordList)
        {
            Console.WriteLine(word);
        }
    }
}