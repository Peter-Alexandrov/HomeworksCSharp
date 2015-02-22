using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("Enter S:");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter s number:");
        string bin = Console.ReadLine();
        Console.WriteLine("Enter D:");
        int d = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0, k = bin.Length - 1; i < bin.Length; i++, k--)
        {
            if (bin[i] != '0')
            {
                int digit;
                
                    switch (bin[i])
                    {
                        case '1': digit = 1;
                            break;
                        case '2': digit = 2;
                            break;
                        case '3': digit = 3;
                            break;
                        case '4': digit = 4;
                            break;
                        case '5': digit = 5;
                            break;
                        case '6': digit = 6;
                            break;
                        case '7': digit = 7;
                            break;
                        case '8': digit = 8;
                            break;
                        case '9': digit = 9;
                            break;
                        case 'a':
                        case 'A': digit = 10;
                            break;
                        case 'b':
                        case 'B': digit = 11;
                            break;
                        case 'c':
                        case 'C': digit = 12;
                            break;
                        case 'd':
                        case 'D': digit = 13;
                            break;
                        case 'e':
                        case 'E': digit = 14;
                            break;
                        case 'f':
                        case 'F': digit = 15;
                            break;
                        default: digit = 0;
                            break;
                    }
                
                sum += digit * (int)Math.Pow(s, k);
            }
        }
        string hex = "";
        while (sum != 0)
        {
            int reminder = sum % d;
            hex = DecToHex(reminder) + hex;
            sum /= d;
        }
        Console.WriteLine(hex);
    }

    static string DecToHex(int p)
    {
        if (p < 10)
        {
            return p.ToString();
        }
        else
        {
            switch (p)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: return "";
            }
        }
    }
}


