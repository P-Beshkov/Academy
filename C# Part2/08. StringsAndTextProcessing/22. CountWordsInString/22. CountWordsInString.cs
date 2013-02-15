/*22. Write a program that reads a string from the console and lists 
 * all different words in the string along with information how many 
 * times each word is found. */

using System;
using System.Collections.Generic;

class CountWordsInString
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
        string[] allWords = text.Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new List<string>();
        List<int> wordsCount = new List<int>();
        foreach (string word in allWords)
        {
            if (words.Contains(word) == false)
            {
                words.Add(word);
                wordsCount.Add(1);
            }
            else
            {
                int index = words.IndexOf(word);
                wordsCount[index]++;
            }
        }
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine("{0,15} - {1}",words[i],wordsCount[i]);
        }

    }
}