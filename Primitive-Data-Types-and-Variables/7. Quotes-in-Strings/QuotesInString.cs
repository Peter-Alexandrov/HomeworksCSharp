using System;


class Program
{
    static void Main()
    {
        string variant1 = "The \"use\" of quotations causes difficulties";
        string variant2 = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(variant1);
        Console.WriteLine(variant2);
    }
}

