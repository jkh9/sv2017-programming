/*
Ex.302: Vector2D

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

public sealed class Vector2D
{
    private double x;
    private double y;

    public Vector2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double GetX()
    {
        return x;
    }

    public double GetY()
    {
        return y;
    }

    public void SetX(double newX)
    {
        x = newX;
    }
    
    public void SetY(double newY)
    {
        y = newY;
    }
      
    public override string ToString()
    {
        return "<" + x + "," + y  + ">";
    }
    
    public void Add(Vector2D v2)
    {
        x += v2.x;
        y += v2.y;
    }

    public double GetLength()
    {
        return Math.Sqrt(x*x + y*y);
    }
}



public class VectorTest
{
    public static void Main()
    {
        Vector2D v = new Vector2D(10, -3.5);
        v.SetX(11);
        
        v.Add( new Vector2D(-5, 2) );
        Console.WriteLine(v);
    }
}

