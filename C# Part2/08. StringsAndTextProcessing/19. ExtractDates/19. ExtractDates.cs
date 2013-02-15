/* 19. Write a program that extracts from a given text all dates
 * that match the format DD.MM.YYYY. Display them in the standard 
 * date format for Canada. */
using System;
using System.Text.RegularExpressions;
using System.Globalization;
class ExtractDates
{
    static void Main()
    {
        string text = "13.02.2001 02.21.2013 ";
        string pattern = @"\b\d{2}.\d{2}.\d{4}\b";
        MatchCollection matches = Regex.Matches(text,pattern);
        foreach (Match match in matches)
        {
            DateTime date;
            if (DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }

        //FOR\((?<a>\d+),?(?<b>\d+)\)\s*;
    }
}