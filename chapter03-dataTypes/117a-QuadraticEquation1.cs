/*
Write a program to calculate the solutions for a 
quadratic equation y = Ax2 + Bx + C
*/

using System;

public class SecondDegree
{
    public static void Main()
    {
        double a, b, c;
        double x1, x2;
        
        Console.Write("Enter the first coefficient (a): ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the second coefficient (b): ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third coefficient (c): ");
        c = Convert.ToDouble(Console.ReadLine());
        
        x1 = (-b + Math.Sqrt(b*b - 4*a*c)) / (2 * a);
        x2 = (-b - Math.Sqrt(b*b - 4*a*c)) / (2 * a);
        Console.WriteLine("Solutions: " + x1 + "," + x2);
    }
}
