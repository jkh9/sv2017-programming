/*
Ex.302: Vector2D (V2: Properties)

Create a class Vector2D to represent a vector in the bidimensional space (with 
coordinates X and Y):

- A constructor to set the values for X and Y.

- Setters and getters for both.

- A method "ToString", which would return "<2,-3>"

- A method "GetLength" to return the length of the vector (square root of x2+y2)

- A method "Add", to sum a vector (which will be passed as a parameter) to the 
  current one (the result will be: <x+x, y+y> )

Create a test program, to try these capabilities.
*/

using System;

public class Vector2D
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return "<" + X + "," + Y + ">";
    }

    public void Add(Vector2D v2)
    {
        X += v2.X;
        Y += v2.Y;
    }

    public double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}



public class VectorTest
{
    public static void Main()
    {
        Vector2D v = new Vector2D(10, -3.5);
        v.X = 11;

        v.Add(new Vector2D(-5, 2));
        Console.WriteLine(v);
    }
}
