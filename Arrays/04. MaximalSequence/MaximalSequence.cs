using System;

class MaximalSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of array: ");
        int n = int.Parse(Console.ReadLine());
        int maxSeq = 1;
        int currSeq = 1;
        int number = 0;
        int[] myArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("use enter");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (myArr[i] == myArr[i + 1])
            {
                currSeq++;
            }
            else
            {
                currSeq = 1;
            }
            if (currSeq >= maxSeq)
            {
                maxSeq = currSeq;
                number = myArr[i];
            }
        }
        for (int i = 0; i < maxSeq; i++)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}

