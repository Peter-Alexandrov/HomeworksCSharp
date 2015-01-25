using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radius of a circle: ");
        double r;
        bool success = double.TryParse(Console.ReadLine(),out r);

        if (!success)
        {
            Console.WriteLine("This is not a number");
            return;
        }
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Perimeter is: {0:0.00} ; Area is: {1:0.00}",perimeter,area);

    }
}
