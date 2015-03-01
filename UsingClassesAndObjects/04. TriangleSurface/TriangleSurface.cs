//Problem 4. Triangle surface
//
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
using System.Threading;
using System.Globalization;

class TriangleSurface
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("............Pick calculation type.................");
        Console.WriteLine();
        Console.WriteLine("For side and an altitude press ----------------->1");
        Console.WriteLine("For three sides press -------------------------->2");
        Console.WriteLine("For two sides and an angle between them press--->3");
        string type = Console.ReadLine();
        switch (type)
        {
            case "1":
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine(SideAndAltitude(side, altitude));
                break;
            case "2":
                Console.Write("Enter side A: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Enter side C: ");
                double side3 = double.Parse(Console.ReadLine());
                Console.WriteLine(Threesides(side1, side2, side3));

                break;
            case "3":
                Console.Write("Enter side A: ");
                double s1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                double s2 = double.Parse(Console.ReadLine());
                Console.Write("Enter angle: ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine(TwoSidesAndAngle(s1, s2, angle));
                break;
        }
    }

    static double SideAndAltitude(double s, double a)
    {
        double result = (s * a) / 2;
        return result;
    }
    static double Threesides(double s1, double s2, double s3)
    {
        double semiperimeter = (s1 + s2 + s3) / 2;
        double result =
        Math.Sqrt(semiperimeter * (semiperimeter - s1) * (semiperimeter - s2) * (semiperimeter - s3));
        return result;
    }
   static double TwoSidesAndAngle(double s1, double s2, double a)
    {
        double result = (s1 * s2 * Math.Sin(a)) / 2;
        return result;
    }
}

