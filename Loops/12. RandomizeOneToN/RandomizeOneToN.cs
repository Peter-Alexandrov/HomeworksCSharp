using System;
using System.Linq;

class RandomizeOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i + 1;
        }
        Random rnd = new Random();
        int[] randomized = nums.OrderBy(x => rnd.Next()).ToArray();
        foreach (var item in randomized)
        {
            Console.Write("{0} ", item);
        }
    }
}

