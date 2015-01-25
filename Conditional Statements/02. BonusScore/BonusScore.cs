using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please enter number from 1 to 9");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 3)
        {
            Console.WriteLine("Your bonus is:"+n * 10);
        }
        else if (4 <= n && n <= 6)
        {
            Console.WriteLine("Your bonus is:"+n * 100);
        }
        else if (7 <= n && n <= 9)
        {
            Console.WriteLine("Your bonus is:"+n * 1000);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

