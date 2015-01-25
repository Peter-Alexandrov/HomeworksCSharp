using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string[] validCards = new string[] { 
                                                "2", 
                                                "3", 
                                                "4", 
                                                "5", 
                                                "6", 
                                                "7", 
                                                "8", 
                                                "9", 
                                                "10", 
                                                "J", 
                                                "Q", 
                                                "K", 
                                                "A" 
                                            };
        Console.Write("Enter card sign: ");
        string input = Console.ReadLine().ToUpper();
        bool isValid = false;
        for (int i = 0; i < validCards.Length; i++)
        {
            if (input == validCards[i])
            {
                isValid = true;
                break;
            }
        }
        Console.WriteLine(isValid?"Yes":"No");
    }
}

