using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Put your integer number here:");
        int number = int.Parse
            (Console.ReadLine());
        int rest = number % 2;
        if (rest == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}




