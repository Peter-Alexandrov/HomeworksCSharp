using System;

class StringsObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object hail = hello + " " + world;
        string printPreview = (string)hail;
        Console.WriteLine(printPreview);
        
     
    }
}