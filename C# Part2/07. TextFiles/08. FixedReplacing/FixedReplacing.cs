//08. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class FixedReplacing
{
    static void Main()
    {
        string inputDir = "..//..//TestFile.txt";
        string outputDir = "..//..//TempFile.txt";
        using (StreamReader reader = new StreamReader(inputDir))
        {
            using (StreamWriter writer = new StreamWriter(outputDir))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); 
                }                   
            }
        }
        File.Delete(inputDir);
        File.Move(outputDir, inputDir);
        File.Delete(outputDir);
    }
}