//Write a program that replaces all occurrences of the substring "start" 
//with the substring "finish" in a text file. Ensure it will work with 
//large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubstringInFile
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("..\\..\\testfile.txt"))
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\result.txt"))
            {
                string line;
                line = reader.ReadLine();
                while (line != null)
                {
                    line.Replace("start", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
                
            }
        }
    }
}