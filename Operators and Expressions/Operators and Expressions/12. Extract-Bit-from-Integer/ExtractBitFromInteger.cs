using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter number ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(16, '0'));

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("The bit at position {0} is {1}",
            position, bit);
    }
}