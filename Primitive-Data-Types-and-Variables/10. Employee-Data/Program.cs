using System;

class Program
{
    static void Main()
    {
        string firstName = "Georgi";
        string lastName = "Georgiev";
        byte age = 38;
        char gender = 'm';
        long personalID = 8306112507;
        int uniqueEmpNumber = 27560246;
        string output = String.Format("first name: {0}; last name: {1}; age: {2}; gender: {3}; \npersonal ID: {4}; unique employee number: {5};",
            firstName, lastName, age, gender, personalID, uniqueEmpNumber);
        Console.WriteLine(output);
    }
}

