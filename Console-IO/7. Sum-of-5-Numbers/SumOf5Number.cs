using System;


class SumOf5Number
{
    static void Main()
    {
        Console.WriteLine("Enter five integer numbers separated by single space");
        string numbers = Console.ReadLine();
        string[] separated = numbers.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < separated.Length; i++)
        {
            sum += double.Parse(separated[i]);
        }
        Console.WriteLine(sum);
    }
}
