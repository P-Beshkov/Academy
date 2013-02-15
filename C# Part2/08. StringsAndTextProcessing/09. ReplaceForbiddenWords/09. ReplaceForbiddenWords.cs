/*09. We are given a string containing a list of forbidden words and a 
 * text containing some of these words. Write a program that replaces 
 * the forbidden words with asterisks. Example:
 * Microsoft announced its next generation PHP compiler today. It is 
 * based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 * Words: "PHP, CLR, Microsoft"		The expected result:
 * ********* announced its next generation *** compiler today. It is based 
 * on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        List<string> forbiddenWords = new List<string>
        { 
            "PHP",
            "CLR",
            "Microsoft"
        };
        string rawText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] allWords = rawText.Split(' ', ',');
        
        StringBuilder buffer = new StringBuilder();
        foreach (string word in allWords)
        {
            if (forbiddenWords.Contains(word))
            {
                buffer.Append(new String('*', word.Length)+" ");
            }
            else if (word.Length == 0)
            {
                buffer.Append(". ");
            }
            else
            {
                buffer.Append(word+" ");
            }
        }
        string editedText = buffer.ToString();
        Console.WriteLine(editedText);
    }
}