//11. Write an expression that extracts from a given integer i the value of a 
//given bit number b. Example: i=5; b=2 -> value=1.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Integer to extract: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Bit to extract: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1;

        mask <<= b;
        mask &= i;
        mask >>= b;
        Console.WriteLine("The {0}-bit of {1} is: {2}", b, i, mask);
    }
}