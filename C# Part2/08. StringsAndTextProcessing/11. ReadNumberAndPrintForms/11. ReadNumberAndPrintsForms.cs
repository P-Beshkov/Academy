/*11. Write a program that reads a number and prints it as a decimal 
 * number, hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols. */

using System;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}", value);
        Console.WriteLine("{0,15:X}", value);
        Console.WriteLine("{0,15:P}", value);
        Console.WriteLine("{0,15:E}", value);
    }
}