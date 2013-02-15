//01. Write a program that reads a year from the console and 
//checks whether it is a leap. Use DateTime.

using System;

class CheckLeapYear
{    
    static void Main()
    {
        int year;
        Console.Write("Enter year: ");
        year = int.Parse(Console.ReadLine());
        bool yearIsLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Year is leap: {0}",yearIsLeap);
    }
}