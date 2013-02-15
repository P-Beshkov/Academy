//03. Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
//Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch 
//all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadAndPrintFile
{
    static void Main()
    {

        Console.Write("Enter full file path: ");
        string filePath = Console.ReadLine();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path must not be empty");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path");
        }       
        catch (IOException)
        {
            Console.WriteLine("Input/Output exception");
        }

    }
}