using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter Web site: ");
        string website = Console.ReadLine();
        Console.Write("Enter Manager first name: ");
        string managerFName = Console.ReadLine();
        Console.Write("Enter Manager last name: ");
        string managerLName = Console.ReadLine();
        Console.Write("Enter Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Enter Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber == "" ? "(no fax)" : faxNumber);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFName,
            managerLName, managerAge, managerPhone);
    }
}

