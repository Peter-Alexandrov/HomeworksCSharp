﻿using System;
class FillTheMatrix
{
    //         Write a program that fills and prints a matrix of size (n, n)
    //
    //         Example for n=4:
    //     
    //         a)                   b)                    c)                     d)*
    //         1 5  9 13            1 8  9 16             7 11 14 16             1 12 11 10
    //         2 6 10 14            2 7 10 15             4  8 12 15             2 13 16  9
    //         3 7 11 15            3 6 11 14             2  5  9 13             3 14 15  8
    //         4 8 12 16            4 5 12 13             1  3  6 10             4  5  6  7 

    static void Main()
    {
        Console.WriteLine("Enter integer number n (n row, n columns):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        //a)
        Console.WriteLine("This is case a):");
        int number = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, number++)
            {
                matrix[row, col] = number;
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //b)
        Console.WriteLine("This is case b):");
        number = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = number++;
                }
            }
            else
            {
                for (int row = (matrix.GetLength(0) - 1); row >= 0; row--)
                {
                    matrix[row, col] = number++;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //c)
        Console.WriteLine("This is case c):");
        number = 1;
        for (int row = (n - 1); row >= 0; row--)
        {
            int tempRow = row;

            for (int col = 0; col < (n - row); col++)
            {
                matrix[tempRow, col] = number++;
                tempRow++;
            }
        }
        number = n * n;
        for (int row = 0; row < (n - 1); row++)
        {
            int tempRow = row;

            for (int col = (n - 1); tempRow >= 0; col--)
            {
                matrix[tempRow, col] = number--;
                tempRow--;
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}