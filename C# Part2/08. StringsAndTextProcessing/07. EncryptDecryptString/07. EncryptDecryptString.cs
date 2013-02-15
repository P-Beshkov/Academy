/* 07. Write a program that encodes and decodes a string using given 
 * encryption key (cipher). The key consists of a sequence of characters. 
 * The encoding/decoding is done by performing XOR (exclusive or) 
 * operation over the first letter of the string with the first of the 
 * key, the second – with the second, etc. When the last key character 
 * is reached, the next is the first. */

using System;
using System.Text;

class Program
{
    static private string Encode(string message, string key)
    {
        StringBuilder buffer = new StringBuilder();
        int keyIndex=0;
        foreach (char item in message)
        {
            if (keyIndex >= key.Length)
            {
                keyIndex = 0;
            }
            buffer.Append((char)(item ^ key[keyIndex]));
        }
        return buffer.ToString();
    }
    static void Main()
    {
        string message = "some test message for encode";
        string key = "very simple key";
        string encoded = Encode(message, key);
        Console.WriteLine("Original message: "+message);
        Console.WriteLine();
        Console.WriteLine("Encoded: "+encoded);
    }
}