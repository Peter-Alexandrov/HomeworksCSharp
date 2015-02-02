using System;
using System.Numerics;

class CalculateFactoriels
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialNDevK = 1;
        BigInteger factorialNSubstrK = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorialNDevK = factorialNDevK * i;
        }
        for (int i = 1; i <= n - k; i++)
        {
            factorialNSubstrK = factorialNSubstrK * i;
        }
        BigInteger combNum = factorialNDevK / factorialNSubstrK;
        Console.WriteLine(combNum);
    }
}
