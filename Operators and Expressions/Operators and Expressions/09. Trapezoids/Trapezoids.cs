using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter side A :");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B :");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height H :");
        double heightH = double.Parse(Console.ReadLine());
        double area = (sideA + sideB) * heightH / 2;
        Console.WriteLine("Trapezoid area is:{0}", area);
    }
}

