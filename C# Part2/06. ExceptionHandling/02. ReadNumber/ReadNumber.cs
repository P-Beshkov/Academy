﻿//02. Write a method ReadNumber(int start, int end) that enters an integer number
//in given range [start…end]. If an invalid number or non-number text is entered, 
//the method should throw an exception. Using this method write a program that enters 10 numbers:
//		a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadNumbers
{
    static private int ReadNumber (int start, int end)
    {
        int number=0;
        Console.Write("Enter an integer[{0} ...{1}] - ",start,end);
        string rawNumber = Console.ReadLine();
        if (!int.TryParse(rawNumber,out number))
        {
            throw new ArgumentException("Invalid number");
        }
        if (number<start || number>end)
        {
            throw new ArgumentOutOfRangeException("Number must be[" + start + ".." + end + "]");
        }
        return number;
    }
    static void Main()
    {
        int start=100;
        int end = 1000;
        int prevNumber = ReadNumber(start, end);
        for (int i = 0; i < 10; i++)
        {
            int currentNumber = ReadNumber(start, end);
            if (prevNumber >= currentNumber)
            {
                throw new ArgumentException("Every next value must be greater");
            }
            prevNumber = currentNumber;
        }
    }
}