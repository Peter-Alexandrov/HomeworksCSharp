using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Console.Write("Please enter an integer: ");
                int integerNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine(++integerNum);
                break;
            case "2": Console.Write("Please enter a double: ");
                double doubleNum = Double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleNum);
                break;
            case "3": Console.Write("Please enter a string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
                break;
            default: Console.WriteLine("Invalid number");
                break;
        }
    }
}
           



        

    


