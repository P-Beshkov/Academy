//05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        int mask = 1;
        mask <<= 3;
        mask &= value;
        mask >>= 3;
        Console.WriteLine("Bit 3 is: " + mask);
    }
}