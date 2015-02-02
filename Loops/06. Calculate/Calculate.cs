using System;

class Calculate
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        long result = 1;

        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);

    }
}
