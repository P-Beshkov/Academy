//06. Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file. Example:
//Ivan		->	George
//Peter		->	Ivan
//Maria		->	Maria
//George	->	Peter

using System;
using System.Collections.Generic;
using System.IO;

class ReadAndSortNames
{
    static void Main()
    {
        List<string> names = new List<string>();
        using (StreamReader reader = new StreamReader("..\\..\\names.txt"))
        {
            string line = reader.ReadLine();
            while (line!=null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
        }
        names.Sort();
        using (StreamWriter writer = new StreamWriter("..\\..\\SortedNames.txt"))
        {
            foreach (string item in names)
            {
                writer.WriteLine(item);
            }
        }
    }
}