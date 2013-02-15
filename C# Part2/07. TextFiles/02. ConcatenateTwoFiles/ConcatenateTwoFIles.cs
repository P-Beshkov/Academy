//02. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTwoFIles
{
    static void Main()
    {
        StreamReader file1 = new StreamReader("..\\..\\file1.txt");
        StreamReader file2 = new StreamReader("..\\..\\file2.txt");
        StreamWriter result = new StreamWriter("..\\..\\Combined.txt");
        result.WriteLine(file1.ReadToEnd());
        result.WriteLine(file2.ReadToEnd());
        file1.Close();
        file2.Close();
        result.Close();
    }
}