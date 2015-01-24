using System;

class FourDigit
{
    static void Main()
    {
        Console.WriteLine("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = (number % 10);
        int sum = a + b + c + d;
        Console.WriteLine("The sum of your 4 digits is: {0}", sum);
        Console.WriteLine("In reversed order is: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchange second and third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}
