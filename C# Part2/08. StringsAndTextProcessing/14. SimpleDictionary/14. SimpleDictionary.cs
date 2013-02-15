/*14. A dictionary is stored as a sequence of text lines containing words
 * and their explanations. Write a program that enters a word and 
 * translates it by using the dictionary. Sample dictionary:
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes */
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] dictionary = 
        {
        ".NET – platform for applications from Microsoft",
        "CLR – managed execution environment for .NET",
        "namespace – hierarchical organization of classes"
        };
        string word = "CLR";
        foreach (string entry in dictionary)
        {
            if (entry.Contains(word))
            {
                int dashIndex = entry.IndexOf('–');
                Console.WriteLine("{0} is {1}",word,entry.Substring(dashIndex+2));
                return;
            }
        }
        Console.WriteLine("Sorry, not found!");
    }
}
