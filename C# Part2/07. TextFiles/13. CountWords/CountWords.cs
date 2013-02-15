//13. Write a program that reads a list of words from a file words.txt and finds how
//many times each of the words is contained in another file test.txt. The result should
//be written in the file result.txt and the words should be sorted by the number of their 
//occurrences in descending order. Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class CountWords
{

    static void Main()
    {
        string fileSourcePath = "..//..//Test.txt";
        string fileResultPath = "..//..//Result.txt";
        string fileDictionaryPath = "..//..//Words.txt";

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader(fileDictionaryPath))
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                    dictionary.Add(line, 0);
                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(fileSourcePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    List<string> wordList = new List<string>(dictionary.Keys);
                    foreach (string word in wordList)
                    {
                        string regex = String.Format("\\b{0}\\b", word);
                        MatchCollection matches = Regex.Matches(line, regex);
                        dictionary[word] += matches.Count;
                    }
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(fileResultPath, false))
            {
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    writer.Write(wordCounter.Key);
                    writer.Write("-");
                    writer.WriteLine(wordCounter.Value);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("io operation error!");
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("error while trying to count word!");
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("error while trying to count word!");
            Console.WriteLine(ex.Message);
        }
        catch (RegexMatchTimeoutException ex)
        {
            Console.WriteLine("error while trying to count word!");
            Console.WriteLine(ex.Message);
        }
    }
}