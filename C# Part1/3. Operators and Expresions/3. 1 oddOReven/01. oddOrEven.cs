//01. Write an expression that checks if given integer is odd or even

using System;

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        int mask = 1;
                        
        if ((mask & value) == 1)
            Console.WriteLine("Number is odd");
        else
            Console.WriteLine("Number is even");
    }
}