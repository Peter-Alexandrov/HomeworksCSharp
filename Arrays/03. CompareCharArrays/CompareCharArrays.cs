using System;

class CompareCharArrays
{
    static void Main()
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        bool areEqual = true;
        if (str1.Length != str2.Length)
        {
            areEqual = false;
        }
        else
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    areEqual = false;
                    break;
                }
            }
        } 
        Console.WriteLine("The characters are equal: " + areEqual);
    }
}
