//07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. 
//E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int i;

        for (i = 2; i < (n / 2); i++)
            if (n % i == 0)
            {
                i = 1;
                break;
            }
        if (i == 1)
            Console.WriteLine("Is not prime.");
        else
            Console.WriteLine("Is prime.");
    }
}