//Problem 10. Unicode characters
//
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        foreach (var item in text)
        {
            string output = String.Format("\\u{0:X4}", (int)item);
            Console.Write(output);
        }
    }
}
