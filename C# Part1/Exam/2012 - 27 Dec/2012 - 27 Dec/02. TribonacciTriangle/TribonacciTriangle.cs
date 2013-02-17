using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine()),
        secondNumber = long.Parse(Console.ReadLine()),
        thirdNumber = long.Parse(Console.ReadLine());
        int linesCount = int.Parse(Console.ReadLine());
        Console.WriteLine(firstNumber);
        Console.WriteLine("{0} {1}", secondNumber, thirdNumber);
        for (int numbersInRow = 3; numbersInRow <= linesCount; numbersInRow++)
        {
            for (int i = 0; i < numbersInRow; i++)
            {
                long newNumber = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = newNumber;
                Console.Write("{0} ", newNumber);
            }
            Console.WriteLine();
        }
    }
}