using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger doubleNFactDevByNFac = 1;
        BigInteger nPlusOneFac = 1;
        for (int i = n + 1; i <= 2 * n; i++)
        {
            doubleNFactDevByNFac = doubleNFactDevByNFac * i;
        }
        for (int i = 2; i <= n + 1; i++)
        {
            nPlusOneFac = nPlusOneFac * i;
        }
        BigInteger catalan = doubleNFactDevByNFac / nPlusOneFac;
        Console.WriteLine(catalan);
    }
}

