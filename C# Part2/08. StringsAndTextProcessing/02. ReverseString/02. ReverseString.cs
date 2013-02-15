//02. Write a program that reads a string, reverses it and prints 
//the result at the console. Example: "sample" -> "elpmas".
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string justString = Console.ReadLine();
        string reversedString = ReverseString(justString);
        Console.WriteLine(reversedString);
    }
  
    private static string ReverseString(string justString)
    {
        StringBuilder tempBuilder = new StringBuilder();
        for (int i = justString.Length - 1; i >= 0; i--)
        {
            tempBuilder.Append(justString[i]);
        }
        return tempBuilder.ToString();
        
    }
}