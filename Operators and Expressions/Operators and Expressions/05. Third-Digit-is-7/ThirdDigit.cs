using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());
        bool thirdDigit = (number / 100) % 10 == 7;
        Console.WriteLine("Your Third Digit is 7?:{0}", thirdDigit);
    }
}

