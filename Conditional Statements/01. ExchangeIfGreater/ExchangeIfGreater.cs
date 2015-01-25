using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter first number ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number ");
        double b = double.Parse(Console.ReadLine());
        if (a>b)
        {
            double c = b;
            b = a;
            a = c;
        }
        Console.WriteLine(a+" "+b);
    }
}

