using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Please enter positive integer: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = 1; i <= counter; i++)
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i+" ");
            }
        Console.WriteLine("End");
    }

}


