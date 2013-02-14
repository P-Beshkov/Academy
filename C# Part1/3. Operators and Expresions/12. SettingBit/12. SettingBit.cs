//12. We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v 
//at the position p from the binary representation of n.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Number to change: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.Write("Bit to change: ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("What to set[0 or 1]: ");
        int value = int.Parse(Console.ReadLine());
        int mask = 1;
        
        mask <<= pos;
        if (value == 1)
            n = n | mask;
        else
            n = n & ~mask;
        Console.WriteLine(n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}