using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string hexNumber = "";
        while (number > 0)
        {
            long rest = number % 16;
            string digit = "";
            switch (rest)
            {
                case 0:
                    digit = "0";
                    break;
                case 1:
                    digit = "1";
                    break;
                case 2:
                    digit = "2";
                    break;
                case 3:
                    digit = "3";
                    break;
                case 4:
                    digit = "4";
                    break;
                case 5:
                    digit = "5";
                    break;
                case 6:
                    digit = "6";
                    break;
                case 7:
                    digit = "7";
                    break;
                case 8:
                    digit = "8";
                    break;
                case 9:
                    digit = "9";
                    break;
                case 10:
                    digit = "A";
                    break;
                case 11:
                    digit = "B";
                    break;
                case 12:
                    digit = "C";
                    break;
                case 13:
                    digit = "D";
                    break;
                case 14:
                    digit = "E";
                    break;
                case 15:
                    digit = "F";
                    break;
                default:
                    break;
            }
            hexNumber = digit + hexNumber;
            number /= 16;
        }
        Console.WriteLine(hexNumber);
    }
}

