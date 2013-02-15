//09. Write a program that deletes from given text file all odd lines. 
//The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
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
                while (line!=null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        writer.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
        File.Delete(inputDir);
        File.Move(outputDir, inputDir);
        File.Delete(outputDir);
    }
}