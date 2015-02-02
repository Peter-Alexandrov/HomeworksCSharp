using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Please enter positive integer: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}

