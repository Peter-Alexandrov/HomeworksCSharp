//Problem 5. Workdays
//
//Write a method that calculates the number of workdays between today and given date, passed
//as parameter. Consider that workdays are all days from Monday to Friday 
//except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class Workdays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        Console.WriteLine("Calculate your Workdays");
        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter month:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter day:");
        int day = int.Parse(Console.ReadLine());
        DateTime futureDate = new DateTime(year, month, day);
        Console.WriteLine("You are working from now to: {1},{2},{3} =====> {0} Days"
        , checker(now, futureDate), year, month, day);
    }

    static int checker(DateTime now, DateTime futureDate)
    {
        int counter = 0;
        if (now > futureDate)
        {
            DateTime change = now;
            now = futureDate;
            futureDate = change;

        }
        while (now <= futureDate)
        {
            if (!PublicHolidays.Contains(now) && now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday)
            {
                counter++;
            }
            now = now.AddDays(1);
        }
        return counter;
    }

    static readonly DateTime[] PublicHolidays =
        {
            new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
		    new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
		    new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
		    new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
        };
}
