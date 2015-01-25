using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter point X:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter point Y:");
        double y = double.Parse(Console.ReadLine());
        double radius = 2;
        bool result = Math.Sqrt(x * x) + (y * y) <= radius;
        Console.WriteLine(result);
    }
}

