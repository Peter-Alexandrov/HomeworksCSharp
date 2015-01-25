using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter first coefficient:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second coefficient:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third coefficient:");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;
        if (d==0)
        {
         //One real root  
            //x = - b/2a
            double root = (-b) / (2 * a);
            Console.WriteLine("x1=x2={0}",root);
        }
        else
        {
            if (d>0)
            {
                //Two real roots
                double root1 = ((-b) - Math.Sqrt(d)) / (2 * a);
                double root2 = ((-b) + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}",root1,root2);
            }
            else
            {
                //No real roots
                Console.WriteLine("No real roots");
            }
        }
        
    }
}

