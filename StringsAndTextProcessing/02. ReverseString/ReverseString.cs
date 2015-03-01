//Problem 2. Reverse string
//
//Write a program that reads a string, reverses it and prints the result at the console.
//Example:
//
// input	output
// sample	elpmas

using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string to reverse it: ");
        string input = Console.ReadLine();
        char[] reverseInput = input.ToCharArray();
        Array.Reverse(reverseInput);
        input = new string(reverseInput);
        Console.WriteLine("Your string reversed is: "+input);
    }
}

