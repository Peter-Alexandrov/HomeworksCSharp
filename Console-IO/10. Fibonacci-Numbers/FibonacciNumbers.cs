using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());
        long fNumber = 0;
        long sNumber = 1;
        if (n == 1)
        {
            Console.WriteLine(fNumber);
        }
        else if (n == 2)
        {
            Console.WriteLine(fNumber + ", " + sNumber);
        }
        else
        {
            Console.Write(fNumber + ", " + sNumber);

            for (int i = 3; i <= n; i++)
            {
                long newNumber = fNumber + sNumber;
                fNumber = sNumber;
                sNumber = newNumber;
                Console.Write(", {0}", newNumber);
            }
            Console.WriteLine();
        }
    }
}

