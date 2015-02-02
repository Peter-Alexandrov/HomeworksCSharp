using System;
using System.Threading;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", rnd.Next(min, max + 1));
            Thread.Sleep(3);
        }
    }
}

