//05. Write a method that calculates the number of workdays 
//between today and given date, passed as parameter. Consider
//that workdays are all days from Monday to Friday except a 
//fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class CalculateWorkdays
{    
    static private int GetWorkingDays(DateTime dayTo,List<DateTime> holidays)
    {
        int workDays = 0;
        for (DateTime date = DateTime.Today; date < dayTo; date = date.AddDays(1))
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && 
                date.DayOfWeek != DayOfWeek.Sunday && 
                !holidays.Contains(date))
            {
                workDays++;
            }
        }
        return workDays;
    }

    static void Main()
    {
        Console.WriteLine("Enter date to calculate to: ");
        Console.Write("Day: ");
        int day = int .Parse(Console.ReadLine());
        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        DateTime date = new DateTime(year,month,day);
        List<DateTime> holidays = new List<DateTime>
        {
            new DateTime(2013, 1, 1),
            new DateTime(2012, 14, 2),
            new DateTime(2012, 3, 3),
            new DateTime(2012, 4, 4),
            new DateTime(2013, 1, 18)
        };
        Console.WriteLine("Workday this date: {0}",GetWorkingDays(date,holidays));
    }
}