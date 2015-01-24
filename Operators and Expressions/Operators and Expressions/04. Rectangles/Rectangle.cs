using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width:");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle height:");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Your perimeter is {0},and it's area is {1}.", 2 * height + 2 * width, height * width);
    }
}

