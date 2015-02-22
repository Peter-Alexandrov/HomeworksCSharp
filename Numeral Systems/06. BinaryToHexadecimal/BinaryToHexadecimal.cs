using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter Bin number:");
        string bin = Console.ReadLine();
        int sum = 0;
        for (int i = 0, k = bin.Length - 1; i < bin.Length; i++, k--)
        {
            if (bin[i] != '0')
            {
                sum += (int)Math.Pow(2, k);
            }
        }
        string hex = "";
        while (sum != 0)
        {
            int reminder = sum % 16;
            hex = DecToHex(reminder) + hex;
            sum /= 16;
        }
        Console.WriteLine(hex);
    }

    static string DecToHex(int p)
    {
        if (p < 10)
        {
            return p.ToString();
        }
        else
        {
            switch (p)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: return "";
            }
        }
    }
}


