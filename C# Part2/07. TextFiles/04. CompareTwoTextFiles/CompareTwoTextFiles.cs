//04. Write a program that compares two text files line by line and
//prints the number of lines that are the same and the number of lines
//that are different. Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTwoTextFiles
{
    static void Main()
    {
        int differentLinesCount = 0;
        using (StreamReader file1 = new StreamReader("..\\..\\file1.txt"))
        {
            using (StreamReader file2 = new StreamReader("..\\..\\file2.txt"))
            {
                string line1, line2;
                do
                {
                    line1 = file1.ReadLine();
                    line2 = file2.ReadLine();
                    if(line1 == null || line2 == null)
                    {
                        break;
                    }
                    if (line1.CompareTo(line2) == 0)
                    {
                        Console.WriteLine(line1);
                    }
                    else
                    {
                        differentLinesCount++;
                    }
                }
                while (true);
            }
        }
        Console.WriteLine("Different lines = {0}",differentLinesCount);
    }
}