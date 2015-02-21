﻿//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;
using System.Linq;

class SayHello
{
    static void Main()
    {
        string name = AskName();
        CheckString(name);
    }

    static string AskName()
    {
        string name;
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        return name;
    }

    static void CheckString(string str)
    {
        bool isCorrect = str.All(Char.IsLetter);
        if (isCorrect)
        {
            Console.WriteLine("Hello, {0}!", str);
        }
        else
        {
            Console.WriteLine("Invalid format!");
        }
    }
}