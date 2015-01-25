using System;

class WeightOnMoon
{
    static void Main()
    {
        Console.Write("Enter Your Weight:");
        double earthWeight = double.Parse(Console.ReadLine());
        double gravitationalRatio = 0.17;
        double moonWeight = earthWeight * gravitationalRatio;
        Console.WriteLine("Your weight on the moon will be:{0}", moonWeight);
    }
}

