//04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        Console.Write("Third digit is 7: ");
        Console.WriteLine((value % 1000) / 100 == 7);
    }
}
