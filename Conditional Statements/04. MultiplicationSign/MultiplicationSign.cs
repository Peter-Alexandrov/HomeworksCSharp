using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
            {
                Console.WriteLine("-");
            }
            else if ((a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}

