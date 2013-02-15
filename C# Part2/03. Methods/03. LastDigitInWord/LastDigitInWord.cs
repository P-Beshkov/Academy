//03. Write a method that returns the last digit of given integer as an 
//English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

class LastDigitInWord
{
    static private string LastDigit(int intValue)
    {
        int lastDigit = intValue % 10;
        string result;
        switch (lastDigit)
        {
            case 1: result = "one";
                break;
            case 2: result = "two";
                break;
            case 3: result = "three";
                break;
            case 4: result = "four";
                break;
            case 5: result = "five";
                break;
            case 6: result = "six";
                break;
            case 7: result = "seven";
                break;
            case 8: result = "eight";
                break;
            case 9: result = "nine";
                break;
            case 0: result = "zero";
                break;
            default: result = "digit not found";
                break;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter integer: ");
        int intValue = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Last digit as a word: {0}", LastDigit(intValue));
    }
}