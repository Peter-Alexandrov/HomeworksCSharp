using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter an Integer Number:");
        int number = int.Parse(Console.ReadLine());
        bool check = (number % 7 == 0 && number % 5 == 0 && number != 0);

        Console.WriteLine("Number {0} can be divided by 7 and 5 \n{1}",number,check);
    }
}

