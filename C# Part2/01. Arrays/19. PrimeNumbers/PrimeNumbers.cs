//15. Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class Program
{
    static void Main()
    {
        long[] numbers = new long[10000000];        
        long crosser = 2;

        while (crosser < numbers.Length)
        {
            if (numbers[crosser] == 0)
            {
                Console.Write(crosser+" ");
                Console.Write("\r");
                long index = crosser * crosser;
                while (index < numbers.Length)
                {
                    numbers[index] = 1;
                    index += crosser;
                }
            }
            crosser++;
        }
    }
}