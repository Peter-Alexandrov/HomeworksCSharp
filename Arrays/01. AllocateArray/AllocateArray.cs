using System;

class AllocateArray
{
    static void Main()
    {
        int[] myArray = new int[20];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i * 5;
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        } 
        Console.WriteLine();
    }
}

