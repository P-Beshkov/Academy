//12. Write a program that removes from a text file all words listed in
//given another text file. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveListedWords
{
    static void Main()
    {
        StreamReader reader;
        string inputDir = "..//..//TestFile.txt",
            outputDir = "..//..//TempFile.txt";
        
        string regex = @"\b(" + string.Join("|", File.ReadAllLines("../../Words.txt")) + @")\b";
        using (reader = new StreamReader(inputDir))
        {
            using (StreamWriter writer = new StreamWriter(outputDir))
            {
                string line;
                line = reader.ReadLine();                
                while (line != null)
                {
                    string replacedString = Regex.Replace(line, regex, String.Empty);
                    writer.WriteLine(replacedString);
                    line = reader.ReadLine();
                    
                }
            }
        }
        File.Delete(inputDir);
        File.Move(outputDir, inputDir);
        File.Delete(outputDir);
    }
}