using System;
using System.Numerics;
using System.Linq;


class OddAndEvenProduct
{
    static void Main()
    {
        int[] numbersInLine = Console.ReadLine()
               .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x)).ToArray();
        BigInteger oddProduct = 1;
        BigInteger evenProduct = 1;

        for (int i = 0; i < numbersInLine.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= numbersInLine[i];
            }
            else
            {
                evenProduct *= numbersInLine[i];
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product: {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product: {0}", oddProduct);
            Console.WriteLine("even product: {0}", evenProduct);
        }
    }
}
