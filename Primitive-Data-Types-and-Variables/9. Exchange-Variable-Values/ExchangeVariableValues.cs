using System;


class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange a = {0}, b = {1}", a, b);
        int c = b;
        b = a;
        a = c;
        Console.WriteLine("After exchange a = {0}, b = {1}", a, b);

    }
}

