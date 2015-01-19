using System;

class Program
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a+" "+b);
        a = a + 5;
        b = b + null;
        Console.WriteLine(a+" "+b);
    }
}

