﻿using System;
class SequenceNMatrix
{
    //We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
    //neighbour elements located on the same line, column or diagonal.
    //Write a program that finds the longest sequence of equal strings in the matrix.

    //matrix	                   result		       
    // ha	 fifi   ho	 hi        ha, ha, ha             
    // fo	 ha	    hi	 xx
    // xxx	 ho	    ha	 xx

    static void Main()
    {
        Console.WriteLine("Enter rows N of the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns M of the matrix: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        Console.WriteLine("Fill the matrix (row by row):");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        Console.WriteLine("This is our matrix");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-5}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        int currentIndex = 0;
        int maxIndex = 0;
        string longSequence = "";

        // Horizontally search

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if ((matrix[row, col] == matrix[row, col + 1]))
                {
                    currentIndex++;
                }
                else
                {
                    currentIndex = 1;
                }
                if (currentIndex > maxIndex)
                {
                    maxIndex = currentIndex;
                    longSequence = matrix[row, col];
                }
            }
            currentIndex = 1;
        }

        // Vertically search

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if ((matrix[row, col] == matrix[row + 1, col]))
                {
                    currentIndex++;
                }
                else
                {
                    currentIndex = 1;
                }
                if (currentIndex > maxIndex)
                {
                    maxIndex = currentIndex;
                    longSequence = matrix[row, col];
                }
            }
            currentIndex = 1;
        }

        // Diagonally search

        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 1;
            }
            if (currentIndex > maxIndex)
            {
                maxIndex = currentIndex;
                longSequence = matrix[row, col];
            }
        }
        Console.Write("The longest sequence of equal strings is: ");
        for (int i = 0; i < maxIndex; i++)
        {
            if (i == maxIndex - 1)
            {
                Console.WriteLine(longSequence);
            }
            else
            {
                Console.Write(longSequence + ", ");
            }
        }
        Console.WriteLine();
    }
}