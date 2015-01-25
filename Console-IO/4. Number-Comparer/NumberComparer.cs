using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double b = double.Parse(Console.ReadLine());
        double greater = Math.Max(a, b);
        Console.WriteLine("Greater is: " + greater);
    }
}

