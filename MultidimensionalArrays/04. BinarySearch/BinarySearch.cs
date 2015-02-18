using System;
class BinarySearch
{
    //Write a program, that reads from the console an array of N integers and an integer K, 
    //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

    static void Main()
    {
        Console.Write("Enter an integer N for length of array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer K: ");
        int k = int.Parse(Console.ReadLine());
        int count = 0;
        int[] myArray = new int[n];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArray);
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] <= k)
            {
                count = myArray[i];
            }
        }
        Array.BinarySearch(myArray, count);
        if (k < myArray[0])
        {
            Console.WriteLine("K is smaller then each element in array ", k);
        }
        else
        {
            Console.WriteLine("{0} is largest number in the array which is <= {1} ", count, k);
        }
    }
}