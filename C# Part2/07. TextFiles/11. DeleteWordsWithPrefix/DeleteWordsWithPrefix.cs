//11. Write a program that deletes from a text file all words that start with 
//the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsWithPrefix
{
    static void Main()
    {
        StreamReader reader;
        string inputDir = "..\\..\\testfile.txt",
            outputDir = "..\\..\\ForRename.txt";
        using (reader = new StreamReader(inputDir))
        {
            using (StreamWriter writer = new StreamWriter(outputDir))
            {
                string line;
                line = reader.ReadLine();
                int prevSymbolIndex = 0;
                while (line != null)
                {
                    string replacedString = (Regex.Replace(line, @"\btest\w*\b", string.Empty));
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