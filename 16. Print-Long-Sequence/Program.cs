using System;

class PrintLongSequence
{

    static void Main()
    {

        for (int i = 2; i < 1002; i++)
        {

            double y = Math.Pow(-1, i);

            Console.Write(i * y);

            Console.Write(',');

        }

    }

}

