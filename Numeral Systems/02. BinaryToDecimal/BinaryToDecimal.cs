using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Binary: ");
        int n = int.Parse(Console.ReadLine());
        int str = n.ToString().Length;
        double sum = 0;
        for (int i = 0; i < str; i++)
        {
            int lastDigit = n % 10; 
            sum = sum + lastDigit * (Math.Pow(2, i));
            n = n / 10;
        }
        Console.WriteLine("Decimal: "+sum);
    }
}
