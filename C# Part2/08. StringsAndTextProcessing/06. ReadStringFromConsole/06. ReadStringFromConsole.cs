/*06. Write a program that reads from the console a string of maximum 
 * 20 characters. If the length of the string is less than 20, the 
 * rest of the characters should be filled with '*'. Print the result 
 * string into the console. */

using System;

class Program
{
    static private string ReadString(int lenght)
    {
        string justString = Console.ReadLine();        
        if (justString.Length <= lenght)
        {
            return justString;
        }
        string result = justString.Substring(0, lenght);
        result += new String('*', justString.Length - lenght);
        return result;
    }
    static void Main()
    {
        string result = ReadString(20);
        Console.WriteLine(result);
    }
}