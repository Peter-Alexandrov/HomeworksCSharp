//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        DateTime date1;
        DateTime date2;

        Console.WriteLine("Enter the first date (dd.MM.yyyy): ");
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date1))
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Enter the first date (dd.MM.yyyy): ");
        }

        Console.WriteLine("Enter the second date (dd.MM.yyyy): ");
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Enter the second date (dd.MM.yyyy): ");
        }

        TimeSpan days = date2 - date1;
        Console.WriteLine("Distance: " + Math.Abs(days.Days));
    }
}