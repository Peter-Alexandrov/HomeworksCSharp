//Problem 1. Leap year
//
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter Year:");
        int year = int.Parse(Console.ReadLine());
        bool leap = DateTime.IsLeapYear(year);
        if (leap)
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not leap years");
        }
    }
}

