/*
Write a program to calculate the solutions for a 
quadratic equation y = Ax2 + Bx + C
*/

// Version 2: more fail safe

using System;

public class SecondDegree2
{
    public static void Main()
    {
        double a, b, c;
        double root1, root2;
        double discr;
        
        Console.Write("Enter the first coefficient (a): ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the second coefficient (b): ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third coefficient (c): ");
        c = Convert.ToDouble(Console.ReadLine());
        
        discr = b*b - 4*a*c;
        if (discr < 0)
            Console.WriteLine("There is no (real) solution");
        else if (discr == 0)
            Console.WriteLine("One solution: {0}", -b / (2 * a));
        else
        {
            root1 = (-b + Math.Sqrt(discr)) / (2 * a);
            root2 = (-b - Math.Sqrt(discr)) / (2 * a);
            Console.WriteLine("Solutions: " + root1 + "," + root2);
        }
    }
}
