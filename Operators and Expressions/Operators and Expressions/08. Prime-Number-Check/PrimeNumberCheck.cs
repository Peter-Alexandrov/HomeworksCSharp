using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Check if number is prime:");
        int number = int.Parse(Console.ReadLine());
        double root = Math.Sqrt(number);
        bool isprime = true;

        if (number <= 1)
        {
            isprime = false;
        }
        else
        {
            for (int i = 2; i <= root; i++)
            {
                if (number % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
        }
        Console.WriteLine("{0} is prime - {1}", number, isprime);
    }
}