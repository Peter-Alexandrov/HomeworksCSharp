using System;

class PrimeNumbers
{
    static void Main()
    {

        int numbers = 10000000;
        bool[] prime = new bool[numbers];

        for (int i = 0; i < numbers; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i < numbers; i++)
        {
            if (prime[i] == true)
            {
                for (int j = 2; j * i < numbers; j++)
                {
                    prime[i * j] = false;
                }

            }
        }

        for (int i = 2; i < numbers; i++)
        {
            if (prime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
