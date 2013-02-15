/* 17. Write a program that reads a date and time given in the 
 * format: day.month.year hour:minute:second and prints the date and 
 * time after 6 hours and 30 minutes (in the same format) along 
 * with the day of week in Bulgarian. */

using System;
using System.Globalization;
class ReadDateAndCalculate
{
    static void Main()
    {
        Console.WriteLine("Enter date in format: day.month.year hour:minute:second");
        string rawDate = Console.ReadLine();
        DateTime date = DateTime.ParseExact(rawDate, "d.MM.yyyy h:mm:ss", CultureInfo.InvariantCulture);
        date.AddHours(6);
        date.AddMinutes(30);
        Console.WriteLine(date);
    }
}