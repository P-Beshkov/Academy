/* 20. Write a program that extracts from a given text all palindromes, 
 * e.g. "ABBA", "lamal", "exe". */

using System;

class ExtractPalindroms
{
    static void Main()
    {
        string text = "ABBA, lamal, exe, notAPalindrom, examaxe";
        string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            int start = 0;
            int end = word.Length-1;
            bool isPalindrom = true;
            for (int index = 0; index < word.Length/2; index++)
            {
                if (word[start] != word[end])
                {
                    isPalindrom = false;
                    break;
                }
            }
            if (isPalindrom)
            {
                Console.WriteLine(word);
            }
        }
    }
}