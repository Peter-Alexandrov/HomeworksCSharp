using System;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by comma:\n");
        int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' },
                      StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        Console.WriteLine("Enter a sum (number S) :");
        int S = int.Parse(Console.ReadLine());
        int currentSUm = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                currentSUm += array[j];

                if (currentSUm == S)
                {
                    Console.WriteLine("The sequence with sum {0} is:\n", S);
                    Console.Write("{");
                    for (int k = i; k <= j; k ++)
                    {
                        Console.Write(k != j ? array[k] + ", " : array[k] + "}");                        
                    }
                    Console.WriteLine();
                    return;
                }
            }
            currentSUm = 0;
        }      
    }
}
