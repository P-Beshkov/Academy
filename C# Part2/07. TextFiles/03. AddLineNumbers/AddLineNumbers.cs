//04. Write a program that reads a text file and inserts line numbers in front
//of each of its lines. The result should be written to another text file.

using System;
using System.IO;

class AddLineNumbers
{
    static void Main()
    {
        int lineNumber = 1;
        using (StreamReader reader = new StreamReader("..\\..\\testfile.txt"))
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\FilWithLines.txt"))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        writer.WriteLine(lineNumber + " " + line);
                        lineNumber++;
                    }
                }
                while (line != null);
                
            }

        }
    }
}