using System;

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position:");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter bit value:");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Before changes: {0}",
            number);
        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(16, '0'));

        if (value == 0)
        {
            number = (number & ~(1 << position));
        }
        else
        {
            number = (number | (1 << position));
        }

        Console.WriteLine("After changes: {0}",
            number);
        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}