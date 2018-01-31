/*
Create a function to calculate the solutions of a quadratic equation 
y=Ax2+Bx+C. The solutions are 

x1 = [-b-Root(b2 - 4ac)] / 2a
x2 = [-b+Root(b2 - 4ac)] / 2a

Remember that the square root can be calculated using Math.Sqrt. The function 
should be named “SolveQuadratic” (2 points). It would be used in a very similar 
way to:

a = 1; b=0; c=-1; 
SolveQuadratic (a, b, c, x1, x2);
Console.WriteLine("Solutions are "+x1+" and "+x2); // -1, 1

(Note: return -9999 for each solution which cannot be found, such as when a=1, 
b=0, c=1)
*/

// Angel Rebollo Berná
 
using System;

class Ex332
{
    public static void SolveQuadratic(double a, double b, double c,
        ref double x1, ref double x2)
    {
        double disc = b * b - 4 * a * c;

        if (disc > 0)
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
        else if (disc == 0)
        {
            x1 = -b  / (2 * a);
            x2 = -9999;
        }
        else // disc < 0
        {
            x1 = -9999;
            x2 = -9999;
        }
    }

    public static void Main()
    {
        double solution1 = 0, solution2 = 0;
        SolveQuadratic(1,0,-1, ref solution1, ref solution2);
        
        Console.WriteLine("X1 = " + solution1);
        Console.WriteLine("X2 = " + solution2);
    }

}
