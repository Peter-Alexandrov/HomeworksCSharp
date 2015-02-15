using System;

class IndexOfLetters
{
    static void Main()
    {
        string[] alphabet = new string[26];
        int first = 65; // A
        for (int i = first; i <first+alphabet.Length ; i++)
        {
            alphabet[i - first] = ((char)i).ToString();
        }
        string word = Console.ReadLine();
        foreach (var letter in word)
        {
            int index = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter.ToString().ToUpper()==alphabet[i])
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine("{0}: {1}",letter,index);
        }
    }
}

