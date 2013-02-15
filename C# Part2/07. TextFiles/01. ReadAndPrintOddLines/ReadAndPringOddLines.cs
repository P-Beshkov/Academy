//01. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class ReadAndPringOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\testfile.txt");
        string line;
        do
        {
            line = reader.ReadLine();
            reader.ReadLine();
            Console.WriteLine(line);
        } 
        while (line!=null);

    }
}