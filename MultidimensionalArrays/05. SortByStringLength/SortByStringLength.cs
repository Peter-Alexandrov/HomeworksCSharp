using System;

class SortByStringLength
{
    static void Main(string[] args)
    {
        //Problem 5. Sort by string length
        //You are given an array of strings. Write a method that sorts the array
        //by the length of its elements (the number of characters composing them).
 
        Console.Write("Enter the length of array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("element [{0}]=", i);
            array[i] = Console.ReadLine();
        }
      
        Array.Sort(array,(x, y) => x.Length.CompareTo(y.Length));

        foreach (var element in array)
        {
            Console.WriteLine(element);
        }
    }
}

