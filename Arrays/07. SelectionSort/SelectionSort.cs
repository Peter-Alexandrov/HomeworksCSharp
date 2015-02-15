using System;

class Program
{
    static void Main()
    {
        int[] number = new int[5];
        for (int j = 0; j < number.Length; j++)
        {
            Console.WriteLine("Enter {0} number: ", j + 1);
            number[j] = Convert.ToInt32(Console.ReadLine());
        }
        int n = number.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (number[i] > number[j])
                {
                    int temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }
            }
        }
        Console.Write("sorted list: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + number[i]);
        }
        Console.WriteLine();
    }
}

