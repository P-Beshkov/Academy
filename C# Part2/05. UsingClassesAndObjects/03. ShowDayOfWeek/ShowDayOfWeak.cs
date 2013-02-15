//03. Write a program that prints to the console 
//which day of the week is today. Use System.DateTime.

using System;

class ShowDayOfWeak
{
    static void Main()
    {
        DateTime data = new DateTime();
        data = DateTime.Today;
        Console.WriteLine("Today is {0}",data.DayOfWeek);
    }
}