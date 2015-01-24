using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 1;
        uint shiftedMask = mask << 3;
        shiftedMask = n & shiftedMask;
        mask = shiftedMask >> 3;
        Console.WriteLine(mask);
    }
}
