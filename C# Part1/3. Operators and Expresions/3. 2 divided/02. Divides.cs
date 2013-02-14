//02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        Console.Write("Divides by 5 and 7: ");
        Console.WriteLine(value % 5 == 0 && value % 7 == 00);
    }
}