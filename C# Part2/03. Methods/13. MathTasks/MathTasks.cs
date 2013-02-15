//13. Write a program that can solve these tasks:
// - Reverses the digits of a number
// - Calculates the average of a sequence of integers
// - Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//    Validate the input data:
// - The decimal number should be non-negative
// - The sequence should not be empty
// - a should not be equal to 0

using System;
using System.Collections.Generic;

class MathTasks
{
    static private int ChooseOption()
    {
        string menu = "1. Reverse the digits of a number\n" +
                      "2. Calculate average of number\n" +
                      "3. Solve the equation a*x+b=0\n" +
                      "0. Exit\n" +
                      "Your choice: ";
        int choice = 0;
        Console.Write(menu);
        do
        {
            choice = int.Parse(Console.ReadLine());
        }
        while (choice < 0 || choice > 5);

        return choice;
    }
    static private void ReverseDigits()
    {
        Console.Clear();
        Console.Write("Enter decimal number[non negative]: ");
        decimal oldValue;
        do
        {
            oldValue = decimal.Parse(Console.ReadLine());
        }
        while (oldValue < 0);
        int dotIndex;
        decimal newValue = 0;
        string digits = oldValue.ToString();
        char[] reversedDigits = digits.ToCharArray();
        Array.Reverse(reversedDigits);
        dotIndex = Array.IndexOf(reversedDigits, '.');
        decimal exponent = 1;
        if (dotIndex == -1)
        {
            dotIndex = reversedDigits.Length;
        }
        for (int i = dotIndex - 1; i >= 0; i--)
        {
            newValue += (reversedDigits[i] - '0') * exponent;
            exponent *= 10;
        }
        if (dotIndex != -1)
        {
            exponent = 0.1M;
            for (int i = dotIndex + 1; i < reversedDigits.Length; i++)
            {
                newValue += (reversedDigits[i] - '0') * exponent;
                exponent *= 0.1M;
            }
        }
        Console.WriteLine("Reversed is: {0}", newValue);
    }
    static private void CalculateAverage()
    {
        Console.Clear();
        List<int> intValues = new List<int>();
        Console.WriteLine("Enter integers[empty line for end]:");
        int value = 0;
        while (int.TryParse(Console.ReadLine(), out value))
        {
            intValues.Add(value);
        }
        if (intValues.Count == 0)
        {
            Console.WriteLine("The sequence is empty!\nExiting!");
            return;
        }
        long sum = 0;
        foreach (int item in intValues)
        {
            sum += item;
        }
        decimal average = sum / intValues.Count;
        Console.WriteLine("Average from this sequence = {0}",average);
    }

    static private void SolveTheEquation()
    {
        Console.Clear();
        decimal a, b;
        Console.WriteLine("Enter coeff for: a*x+b=0");
        Console.Write("a = ");
        a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = decimal.Parse(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Every X is answer");
            }
            else
            {
                Console.WriteLine("Equation doesn't have answer");
            }
        }
        else
        {
            Console.WriteLine("X = {0}",b/a);
        }
    }
    static void Main()
    {
        int choice = 0;
        do
        {
            Console.Clear();
            choice = ChooseOption();
            switch (choice)
            {
                case 1: ReverseDigits();
                    break;
                case 2: CalculateAverage();
                    break;
                case 3: SolveTheEquation();
                    break;                
            }
            Console.ReadKey();
        }
        while (choice != 0);
    }
}