using System;
class CheckBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        bool checkBit = ((number >> position) & 1) == 1;
        Console.WriteLine(checkBit);
    }
}