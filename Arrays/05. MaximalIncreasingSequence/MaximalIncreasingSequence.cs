﻿using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        int startSeq = 0;
        int currCount = 1;
        int maxCount = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("(use enter)");

            if (i != 0)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                }
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    startSeq = i + 1 - maxCount;
                }
            }
        }
        Console.Write("Maximal sequence of increasing elements is: ");
        for (int i = startSeq; i < startSeq + maxCount; i++)
        {
            Console.Write(" {0} ", numbers[i]);
        }
        Console.WriteLine();
    }
}
