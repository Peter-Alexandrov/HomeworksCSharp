using System;

class FormatingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double c = double.Parse(Console.ReadLine());
        string result = String.Format("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|",
            a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        Console.WriteLine(result);
    }
}

