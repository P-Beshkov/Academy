//10. Write a boolean expression that returns if the bit at position p (counting from 0) 
//in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Value: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1;

        mask = mask << p;
        Console.Write("Bit at position {0} is 1: ", p);
        Console.WriteLine((mask & v) > 1);
    }
}
