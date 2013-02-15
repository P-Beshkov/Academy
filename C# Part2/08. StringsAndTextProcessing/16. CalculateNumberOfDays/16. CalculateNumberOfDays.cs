/* 16. Write a program that reads two dates in the format: day.month.year 
 * and calculates the number of days between them. Example:
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days */
using System;
using System.Globalization;

class CalculateNumberOfDays
{
    static void Main()
    {
        string first = "27.02.2006";
        string second = "3.03.2006";
        DateTime firstDate = DateTime.ParseExact(first,"d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(second, "d.MM.yyyy", CultureInfo.InvariantCulture);
        int distance = (int)(secondDate - firstDate).TotalDays;
        Console.WriteLine("Distance = {0} days",distance );
    }
}