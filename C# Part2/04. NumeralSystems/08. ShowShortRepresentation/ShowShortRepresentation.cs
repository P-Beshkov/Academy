//08. Write a program that shows the binary representation of
//given 16-bit signed integer number (the C# type short).

using System;

class ShowShortRepresentation
{
    static void Main()
    {
        string result = string.Empty;
        short number = -10423;
        for (int i = 0; i < 16; i++)
        {
            int bit = (number >> i) & 1;
            result = bit + result;
        }
        Console.WriteLine(result);  
    }
}