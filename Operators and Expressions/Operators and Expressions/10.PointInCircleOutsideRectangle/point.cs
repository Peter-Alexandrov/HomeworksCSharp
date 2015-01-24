using System;
class Point
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool thePointIsInCirle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);
        bool thePointIsInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if (thePointIsInCirle && !thePointIsInRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
