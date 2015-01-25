using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you will enter: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ",i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Your result is: " + sum);
    }
}

