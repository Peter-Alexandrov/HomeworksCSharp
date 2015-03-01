﻿
//   Problem 23. Series of letters
//	 Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//
//Example:
//         input                      output  
//         aaaaabbbbbcdddeeeedssaa    abcdedsa 
﻿
using System;
using System.Text;
class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter series of letters:");
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(text);
        for (int i = 0; i < sb.Length; i++)
        {
            char letter = sb[i];
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[j] == letter)
                {
                    sb.Remove(j, 1);
                    j--;
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(sb);
    }
}