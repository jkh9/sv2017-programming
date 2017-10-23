
// Create a C# program to ask the user for the radius of a circle 
// and display its area. Note: PI must be defined as a "const"

using System;

public class ConstPi
{
    public static void Main()
    {
        const double PI = 3.1415922536;
        
        Console.Write("Enter the radius: ");
        double r = Convert.ToDouble(
            Console.ReadLine());
        
        Console.WriteLine("The area is "+
            PI * r * r);
    }
}
