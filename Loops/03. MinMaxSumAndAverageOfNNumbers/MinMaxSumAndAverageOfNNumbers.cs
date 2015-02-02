using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of numbers to calculate: ");
        int count = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("Enter integer {0}:", i);
            int number = int.Parse(Console.ReadLine());

            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {

                min = number;
            }
            sum = sum + number;

        }
        double avg = (double)sum / count;
        Console.WriteLine("min={0}\nmax={1}\nsum={2}\naverage={3:F2}", min, max, sum, avg);
    }
}