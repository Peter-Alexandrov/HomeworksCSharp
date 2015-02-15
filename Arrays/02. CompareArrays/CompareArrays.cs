using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter first array: ");
        int[] arr1 = new int[4];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter second array: ");
        int[] arr2 = new int[4];
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i]!=arr2[i])
            {
                areEqual = false;
                break;
            }
        }
        Console.WriteLine("Both Arrays are equal: "+areEqual);
    }
}

