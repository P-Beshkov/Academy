//02. Write a program that generates and prints to the 
//console 10 random values in the range [100, 200].

using System;

class PrintRandomNumbersInRange
{
    static void Main()
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < 10; i++)
        {
            int valueGenerated = randomGenerator.Next(100, 201);
            Console.WriteLine("{0,2} random number = {1}", i + 1, valueGenerated);
        }
    }
}