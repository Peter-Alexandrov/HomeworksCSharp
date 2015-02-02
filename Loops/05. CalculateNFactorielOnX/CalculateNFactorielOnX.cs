using System;

class CalculateNFactorielOnX
{
    static void Main()
    {       
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        long factoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += factoriel / (Math.Pow(x, i));
        }
        Console.WriteLine("{0:f5}",sum);
    }
}

