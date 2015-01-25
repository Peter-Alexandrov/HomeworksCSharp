using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        double greater;
        double middle;
        double smaller;

        if (a > b && a > c)
        {
            greater = a;
            if (b > c)
            {
                middle = b;
                smaller = c;
            }
            else
            {
                middle = c;
                smaller = b;
            }
        }
        else if (b > a && b > c)
        {
            greater = b;
            if (a > c)
            {
                middle = a;
                smaller = c;
            }
            else
            {
                middle = c;
                smaller = a;
            }
        }
        else
        {
            greater = c;
            if (a > b)
            {
                middle = a;
                smaller = b;
            }
            else
            {
                middle = b;
                smaller = a;
            }
        }
        Console.WriteLine("Result:{0} {1} {2}", greater, middle, smaller);
    }
}

