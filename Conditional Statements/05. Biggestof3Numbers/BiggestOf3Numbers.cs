using System;

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        double biggestNumber = a;
        if (biggestNumber < b)
        {
            biggestNumber = b;
        }
        if (biggestNumber < c)
        {
            biggestNumber = c;
        }
        Console.WriteLine(biggestNumber);
    }
}


