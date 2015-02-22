using System;

class HexadecimaToBinary
{
    static void Main()
    {

        Console.WriteLine("Enter HexNumber:");
        string hex = Console.ReadLine();
        string bin = "";
        for (int i = 0; i < hex.Length; i++)
        {
            bin = bin + " " + ConvertToBin(hex[i]);
        }
        Console.WriteLine(bin);
    }

    private static string ConvertToBin(char p)
    {
        string result;
        switch (p)
        {
            case '0': result = "0000";
                break;
            case '1': result = "0001";
                break;
            case '2': result = "0010";
                break;
            case '3': result = "0011";
                break;
            case '4': result = "0100";
                break;
            case '5': result = "0101";
                break;
            case '6': result = "0110";
                break;
            case '7': result = "0111";
                break;
            case '8': result = "1000";
                break;
            case '9': result = "1001";
                break;
            case 'a':
            case 'A': result = "1010";
                break;
            case 'b':
            case 'B': result = "1011";
                break;
            case 'c':
            case 'C': result = "1100";
                break;
            case 'd':
            case 'D': result = "1101";
                break;
            case 'e':
            case 'E': result = "1110";
                break;
            case 'f':
            case 'F': result = "1111";
                break;
            default: result = "Invalid Hex digit";
                break;
        }
        return result;
    }
}

